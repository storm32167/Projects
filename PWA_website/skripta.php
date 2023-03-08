<!DOCTYPE html>
<html>

<?php

// Spremanje podataka poslanih putem forme u varijable
$nazivProizvoda = $_POST['nazivProizvoda'];
$opisProizvoda = $_POST['opisProizvoda'];
$sifraProizvoda = $_POST['sifraProizvoda'];
$cijenaProizvoda = $_POST['cijenaProizvoda'];
$kategorijaProizvoda = $_POST['kategorijaProizvoda'];
$slikaProizvoda = $_FILES['slikaProizvoda']['name'];
$arhivirajProizvod = $_POST['arhivirajProizvod'];

// Promjena direktorija u kojem se sprema slika prilikom uploada
$target = 'slike/' . $slikaProizvoda;
move_uploaded_file($_FILES['slikaProizvoda']['tmp_name'], '$target');

// Putanja do direktorija sa slikama
define('UPLPATH', 'slike/');

// Spajanje i spremanje u bazu unosa
$dbc = mysqli_connect('localhost', 'root', 'dzankic234', 'dronovi')
	   or die('Neuspješno spajanje na bazu.');
$query = "INSERT INTO proizvodi (nazivProizvoda,
								 opisProizvoda,
								 sifraProizvoda,
								 cijenaProizvoda,
								 kategorijaProizvoda,
								 slikaProizvoda,
								 arhivirajProizvod)
          VALUES ('$nazivProizvoda',
			  	  '$opisProizvoda',
				  '$sifraProizvoda',
				  '$cijenaProizvoda',
				  '$kategorijaProizvoda',
				  '$slikaProizvoda',
				  '$arhivirajProizvod')";
$result = mysqli_query($dbc, $query)
		  or die('Nije uspjelo spremanje u bazu.');
mysqli_close($dbc);

?>

<!DOCTYPE html>
<html>
<head>
	<title>AKCIJA.hr</title>
	<link rel="stylesheet" type="text/css" href="style.css">
	<meta charset="UTF-8"/>
</head>

<body>
	<div class="container">
	<header>
		<img src="cartlogo.png"/>
	</div>
	<nav>
		<div class="container">
		<ul>
		
		<li><a href="index.html"><b>Početna</b></a></li>
		<li><a href="onama.html"><b>O nama</b></a></li>
		<li><a href="https://www.tvz.hr"><b>TVZ<b></a></li>
		<li><a href="unos.html"><b>Unos<b></a></li>
		<li><a href="proizvodi.php"><b>Proizvodi</b></a></li>
		<li><a href="administrator.php"><b>Administrator</b></a></li>
		  <li><a href="rezervacija.html"><b>Rezervacija</b></a></li>
		  <li><a href="prijava.html"><b>Prijava</b></a></li>
		</ul>
		</div>
	</nav>
	</div>
	<div class="clear"></div>
	
	
		
	
	
		<main>
		
		<section style="height:600px; padding:50px;">
				
			<div class="skripta">
				<a href="#">
					<div class="slika-proizvoda">
						<?php echo '<img class="slika" src="' . UPLPATH . $slikaProizvoda . '" />'; ?>
					</div>
					<div class="opis-proizvoda">
						<h2 class="naziv"><?php echo $nazivProizvoda ;?></h2>
						<h3 class="cijena"><?php echo $cijenaProizvoda; ?></h3>
						<p class="opis"><?php echo $opisProizvoda; ?></p>
					</div>
				</a>
			</div>
		</section>
		
			
		
		
		</main>
			<div class="omot">
			<main>
			<footer>
				<h2>O stranici</h2>
				
				</br>
				<p>Kolegij: PWA</p>
				<p>Tehničko Veleučilište u Zagrebu</p>
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