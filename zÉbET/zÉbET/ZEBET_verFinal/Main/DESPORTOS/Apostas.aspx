<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Apostas.aspx.cs" Inherits="zÉbET.ZEBET_verFinal.Main.DESPORTOS.images.baseball" %>

<!DOCTYPE html>

<html>
  <%--  <%Session["User"] = Request.Form["txt_UserL"]; 
        Session["Saldo"] = %>--%>
	<head>
		<title>Baseball|ZéBet</title>
		<meta charset="us-ascii" />
		<meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />
		<link rel="stylesheet" href="assets/css/cssFutebol.css" />
	</head>
	<body class="is-preload">

		<!-- Header -->
			<div id="header">

				<div class="top">

					<!-- Logo -->
						<div id="logo">
							<span class="image avatar48"><img src="images/appinventor.ai_robson_ppena.CARTOLA.png" alt="" /></span>
							<h1 id="title">ZÉ.<a href="../index.aspx" style="color: #ff6a00">BET</a></h1>
							<p>Site de apostas</p>
						</div>

					<!-- Nav -->
						<nav id="nav">
							<ul>
								<li><a href="../index.aspx" id="top-link"><span class="icon solid fa-home">Inicio</span></a></li>
								<li><a href="../baseball.aspx" id="baseball-link"> <span class="fas fa-baseball-ball" >Baseball</span></></a></li>
								<li><a href="../Basket.aspx" id="A1"> <span class="fas fa-basketball-ball">Basketball </span></></a></li>
								<li><a href="../futbol.aspx" id="Futebol-link"><span class="fas fa-futbol">Futebol  </span></a></li>
                                <li><a href="../HoqueinoGelo.aspx" id="Hoquei no gelo link"><span class="fas fa-hockey-puck">Hoquei no gelo </span></a></li>
                                <li><a href="../snooker.aspx" id="snooker link"><span class="fas fa-dot-circle">snooker </span></a></li>
                                <li><a href="../tennis.aspx" id="tennis link"><span class="fas fa-toilet-paper">tennis </span></a></li>
							</ul>
						</nav>

				</div>

				<div class="bottom">

					<!-- Social Icons -->
						<ul class="icons">
							<li><a href="#" class="icon brands fa-twitter"><span class="label">Twitter</span></a></li>
							<li><a href="#" class="icon brands fa-facebook-f"><span class="label">Facebook</span></a></li>
							<li><a href="#" class="icon brands fa-github"><span class="label">Github</span></a></li>
							<li><a href="#" class="icon brands fa-dribbble"><span class="label">Dribbble</span></a></li>
							<li><a href="#" class="icon solid fa-envelope"><span class="label">Email</span></a></li>
						</ul>

				</div>

			</div>

		<!-- Main -->
			<div id="main">
                <br />
                <h2><p style="text-align:center">BOLETIM</p></h2>
                <hr />

            </div>
		<!-- Footer -->
			<div id="footer">
                
				<!-- Copyright -->
					<ul class="copyright">
						<li>&copy; Untitled. All rights reserved.</li><li>Design: <a href="http://html5up.net">HTML5 UP</a></li>
					</ul>

			</div>

		<!-- Scripts -->
			<script src="assets/js/jquery.min.js"></script>
			<script src="assets/js/jquery.scrolly.min.js"></script>
			<script src="assets/js/jquery.scrollex.min.js"></script>
			<script src="assets/js/browser.min.js"></script>
			<script src="assets/js/breakpoints.min.js"></script>
			<script src="assets/js/util.js"></script>
			<script src="assets/js/main.js"></script>

	</body>
</html>