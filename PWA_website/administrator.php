<?php

// Pokreni session spremanje kako bi mogli privremeno spremiti uspješnu prijavu korisnika
session_start();

?>


<!DOCTYPE html>
<html>
<head>
	<title>AKCIJA.hr</title>
	<link rel="stylesheet" type="text/css" href="style.css">
	<meta charset="UTF-8">
</head>
<?php

// Putanja do direktorija sa slikama
define('UPLPATH', 'slike/');

// Provjera da li se radi o POST requestu
if ($_SERVER['REQUEST_METHOD'] == 'POST') {

	// Provjera da li je korisnik došao s login.html
	if (isset($_POST['prijava'])) {

		// Ukoliko postoji, uništi trenutaèni session prethodno prijavljenog korisnika
		if (isset($_SESSION['$imePrijavljenogKorisnika'])) {
			unset($_SESSION['$imePrijavljenogKorisnika']);
			unset($_SESSION['$levelPrijavljenogKorisnika']);
		}

		// Provjera da li korisnik postoji u bazi uz zaštitu od SQL injectiona
		$prijavaImeKorisnika = $_POST['imeKorisnika'];
		$prijavaLozinkaKorisnika = md5(htmlspecialchars($_POST['lozinkaKorisnika']));

		$dbc = mysqli_connect('localhost', 'root', 'dzankic234', 'dronovi') or die('Neuspješno spajanje na bazu.');
		$sql = "SELECT username, password, level FROM users
				WHERE username = ? AND password = ?";
		$stmt = mysqli_stmt_init($dbc);
		if (mysqli_stmt_prepare($stmt, $sql)) {
			mysqli_stmt_bind_param($stmt, 'ss', $prijavaImeKorisnika, $prijavaLozinkaKorisnika);
        	mysqli_stmt_execute($stmt);
        	mysqli_stmt_store_result($stmt);
     	}
		mysqli_stmt_bind_result($stmt, $imeKorisnika, $lozinkaKorisnika, $levelKorisnika);
		mysqli_stmt_fetch($stmt);

		if (mysqli_stmt_num_rows($stmt) > 0) {
			$uspjesnaPrijava = true;

			if($levelKorisnika == 2) {
				$korisnikJeAdministrator = true;
			}
			else {
				$korisnikJeAdministrator = false;
			}

			$_SESSION['$imePrijavljenogKorisnika'] = $imeKorisnika;
			$_SESSION['$levelPrijavljenogKorisnika'] = $levelKorisnika;
		} else {
			$uspjesnaPrijava = false;
		}
		mysqli_close($dbc);

	}




// Brisanje i promijena arhiviranosti
	$arhivirajProizvod = $_POST['arhivirajProizvod'];
		$sifraProizvoda = $_POST['sifraProizvoda'];
		$obrisiProizvod = $_POST['obrisiProizvod'];
		if ($obrisiProizvod != null) {
			$dbc = mysqli_connect('localhost', 'root', 'dzankic234', 'dronovi')
				   or die('Neuspješno spajanje na bazu.');
			$query = "DELETE FROM proizvodi
					  WHERE sifraProizvoda = '" . $sifraProizvoda . "'";
			$result = mysqli_query($dbc, $query)
					  or die('Neuspješno brisanje.');
			mysqli_close($dbc);
		} else {
			$dbc = mysqli_connect('localhost', 'root', 'dzankic234', 'dronovi')
				   or die('Neuspješno spajanje na bazu.');
			$query = "UPDATE proizvodi
					  SET arhivirajProizvod = '" . $arhivirajProizvod . "'
					  WHERE sifraProizvoda = '" . $sifraProizvoda . "'";
			$result = mysqli_query($dbc, $query)
					  or die('Neuspješna promjena podataka.');
			mysqli_close($dbc);
		}
}

?>





<body>
	<div class="container">
	<header>
		<img src="cartlogo.png"/>
	</div>
	<nav>
		<div class="container">
		<ul>
		
		<li><a href="index.html"><b>Pocetna</b></a></li>
		<li><a href="onama.html"><b>O nama</b></a></li>
		<li><a href="https://www.tvz.hr"><b>TVZ<b></a></li>
		<li><a href="unos.html"><b>Unos<b></a></li>
		<li><a href="proizvodi.php"><b>Proizvodi</b></a></li>
		<li><a href="administrator.php"><b>Administrator</b></a></li>
		  <li><a href="registracija.html"><b>Registracija</b></a></li>
		  <li><a href="prijava.html"><b>Prijava</b></a></li>
		</ul>
		</div>
	</nav>
	</div>
	<div class="clear"></div>
	
	
		
	
	
		<main>
		<section style="height:1000px;">
				<?php

			// Pokaži stranicu ukoliko je korisnik uspješno prijavljen i administrator je
			if (($uspjesnaPrijava == true && $korisnikJeAdministrator == true)
			   || (isset($_SESSION['$imePrijavljenogKorisnika'])) && $_SESSION['$levelPrijavljenogKorisnika'] == 2) {

				$dbc = mysqli_connect('localhost', 'root', 'dzankic234', 'dronovi')
					   or die('Neuspješno spajanje na bazu.');
				$query = "SELECT * FROM proizvodi";
				$result = mysqli_query($dbc, $query)
						  or die('Neuspješno hvatanje proizvoda.');;
				while($row = mysqli_fetch_array($result)) {
					echo '<section id="proizvod">';
						echo '<a href="#">';
							echo '<div class="slika-proizvoda">';
								echo '<img class="slika" src="' . UPLPATH . $row['slikaProizvoda'] . '" />';
							echo '</div>';
							echo '<div class="opis-proizvoda">';
								echo '<h2 class="naziv">' . $row['nazivProizvoda'] . '</h2>';
								echo '<h3 class="cijena">' . $row['cijenaProizvoda'] . ' kn</h3>';
								echo '<p class="opis">' . $row['opisProizvoda'] . '</p>';
								echo '<p class="sifra">#' . $row['sifraProizvoda'] . '</p>';
								echo '<p class="kategorija">@' . $row['kategorijaProizvoda'] . '</p>';
								echo '<form name="promijenaProizvoda" action="administrator.php" method="POST">';
									echo '<input type="hidden"
												 name="sifraProizvoda"
												 id="sifraProizvoda"
												 value="' . $row['sifraProizvoda'] . '"/>';
									if($row['arhivirajProizvod'] == null) {
										echo '<input type="checkbox"
													 name="arhivirajProizvod"
													 id="arhivirajProizvod"/> Arhiviraj?';
									} else {
										echo '<input type="checkbox"
													 name="arhivirajProizvod"
													 id="arhivirajProizvod" checked/> Arhiviraj?';
									}
									echo '<br>';
									echo '<input type="checkbox"
												 name="obrisiProizvod"
												 id="obrisiProizvod"/> Obrisati?';
												 echo '<br>';
									echo '<input type="submit" name="administracija" value="Promijeni">';
								echo '</form>';
							echo '</div>';
						echo '</a>';
					echo '</section>';
				}
				mysqli_close($dbc);

			// Pokaži poruku da je korisnik uspješno prijavljen, ali nije administrator
			} else if ($uspjesnaPrijava == true && $korisnikJeAdministrator == false) {
				echo '<p>Bok ' . $imeKorisnika . '! Uspjesno ste prijavljeni, ali niste administrator.</p>';
			} else if (isset($_SESSION['$imePrijavljenogKorisnika']) && $_SESSION['$levelPrijavljenogKorisnika'] == 1) {
				echo '<p>Bok ' . $_SESSION['$imePrijavljenogKorisnika'] .
					 '! Uspjesno ste prijavljeni, ali niste administrator.</p>';
			} else if ($uspjesnaPrijava == false) {
				echo '<p>Niste uspješno prijavljeni,
					  molimo vas da se <a href="prijava.html">prijavite</a>
					  ili <a href="registracija.html">registrirate</a>.</p>';
			}

			?>
		</section>
		
			
		
		
		</main>
			<div class="omot">
			<main>
			<footer>
				<h2>O stranici</h2>
				
				</br>
				<p>Kolegij: PWA</p>
				<p>Tehnicko Veleuciliste u Zagrebu</p>
				<p>Smjer: Informatizacija i organizacija ureda</p>
				<p>Student: Josip Krljan</p>
				<p>E-mail: <a href="mailto:jkrljan@tvz.hr?Subject=Upit" target="_blank">jkrljan@tvz.hr</a></p>
				<p>Godina: 2018.</p>
			</footer>
			
		</div>
		</main>
</body>
</html>

</html>