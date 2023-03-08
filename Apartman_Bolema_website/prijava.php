<!doctype HTML>
<html>
<head>
<link rel="stylesheet" type="text/css" href="mystyle.css">
<link href="https://fonts.googleapis.com/css?family=Slabo+27px" rel="stylesheet">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<meta charset="UTF-8">
</head>
<body >


<?php
	
	
		
		$ime = $_POST['ime'];
		
		$prezime = $_POST['prezime'];

		$email = $_POST['mail'];
		
		$datumP = $_POST['datumPrijave'];
		
		$datumO = $_POST['datumOdjave'];
	
		$gosti = $_POST['brojGostiju'];
		
		

		

		// Spajanje i spremanje u bazu unosa
		$dbc = mysqli_connect('localhost', 'root', '2702', 'apartman_bolema')
			   or die('Neuspješno spajanje na bazu.');
		$query = "INSERT INTO booking (ime,
										 prezime,
										 email,
										 datumPrijave,
										 datumOdjave,
										 brojGostiju)
				  VALUES ('$ime',
						  '$prezime',
						  '$email',
						  '$datumP',
						  '$datumO',
						  '$gosti')";
		$result = mysqli_query($dbc, $query)
				  or die('Nije uspjelo spremanje u bazu.');
		mysqli_close($dbc);
		
		

		echo  'You have successfully booked your stay at Apartment Bolema<br/>';
		echo 'Back to  <a href="index.html">main page</a>'

?>
					
					
					
</body>
</html>
