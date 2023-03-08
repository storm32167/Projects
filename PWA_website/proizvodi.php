<!DOCTYPE html>
<html>
<?php

// Putanja do direktorija sa slikama
define('UPLPATH', 'slike/');
	
?>



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
		  <li><a href="registracija.html"><b>Registracija</b></a></li>
		  <li><a href="prijava.html"><b>Prijava</b></a></li>
		</ul>
		</div>
	</nav>
	</div>
	<div class="clear"></div>
	
	
		
	
	
		<main>
		<section style="height:1000px;;">
			<?php
				$dbc = mysqli_connect('localhost', 'root', 'dzankic234', 'dronovi')
					   or die('Neuspješno spajanje na bazu.');
				$query = "SELECT * FROM proizvodi";
				$result = mysqli_query($dbc, $query);
				while($row = mysqli_fetch_array($result)) {
					if($row['arhivirajProizvod'] == null ) {
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
							echo '</div>';
						echo '</a>';
					echo '</section>';
					}
				}
				mysqli_close($dbc);
			?>
				
				
		<section>
		
			
		
		
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