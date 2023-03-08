<!DOCTYPE html>
<html>

<?php

$punoImeKorisnika = $_POST['punoImeKorisnika'];
$imeKorisnika = $_POST['imeKorisnika'];
$lozinkaKorisnika = md5(htmlspecialchars($_POST['lozinkaKorisnika']));

// Registracija korisnika u bazi pazeći na SQL injection
$dbc = mysqli_connect('localhost', 'root', 'dzankic234', 'dronovi') or die('Neuspješno spajanje na bazu.');
$sql = "INSERT INTO users (username, password, name)
		VALUES (?, ?, ?)";
$stmt = mysqli_stmt_init($dbc);
if (mysqli_stmt_prepare($stmt, $sql)) {
	mysqli_stmt_bind_param($stmt, 'sss', $imeKorisnika, $lozinkaKorisnika, $punoImeKorisnika);
    mysqli_stmt_execute($stmt);
	$registriranKorisnik = true;
}
mysqli_close($dbc);
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
		<section style="height:400px;"></br></br>
			<?php
				if($registriranKorisnik == true) {
					echo '<p>Korisnik je uspješno registriran!</p>';
				} else {
					echo '<p>Korisnik nije uspješno registriran!</p>';
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