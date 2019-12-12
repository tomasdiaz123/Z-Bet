w<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Apostas.aspx.cs" Inherits="zÉbET.ZEBET_verFinal.Main.DESPORTOS.images.baseball" %>

<!DOCTYPE html>

<html>
    <form id="formA" runat="server">
  <%--  <%Session["User"] = Request.Form["txt_UserL"]; 
        Session["Saldo"] = %>--%>
	<head>Apostas|ZéBet</title>
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
							</ul>
						</nav>

				</div>

				<div class="bottom">

					<!-- Social Icons -->
						<ul class="icon">
						</ul>

				</div>

			</div>

		<!-- Main -->
			<div id="main">
                <br />
                <h2><p style="text-align:center">BOLETIM</p></h2>
     Hoquei<asp:RadioButton ID="rdbHoquei" runat="server" Groupname="desporto" OnCheckedChanged="rdbHoquei_CheckedChanged"/>
           Futebol<asp:RadioButton ID="rdbFutebol" Groupname="desporto" runat="server" OnCheckedChanged="rdbFutebol_CheckedChanged"/>
           Basket<asp:RadioButton ID="rdbBasket" Groupname="desporto" runat="server" OnCheckedChanged="rdbBasket_CheckedChanged" />
           Volei<asp:RadioButton ID="rdbVolei" Groupname="desporto" runat="server" OnCheckedChanged="rdbVolei_CheckedChanged" />
           Snooker<asp:RadioButton ID="rdbSnooker" Groupname="desporto" runat="server" OnCheckedChanged="rdbSnooker_CheckedChanged"/>
           Basebol<asp:RadioButton ID="rdbBasebol" Groupname="desporto" runat="server" OnCheckedChanged="Basebol_CheckedChanged" />
                <asp:Button ID="brnRefresh" runat="server" Text="Atualizar" OnClick="brnRefresh_Click" />
                <hr />
         <h3> Liga Portuguesa</h3>
                <hr />
                <b><asp:Label ID="Label1" runat="server" Text="Benfica[2.15] X[3.0] Porto[2.5]" Visible="False"></asp:Label><br /></b>
                
                <asp:Label ID="Label2" runat="server" Text="Aves[3.15] X[3.0] Sporting[1.55]" Visible="False"></asp:Label><br />
                <asp:Label ID="Label3" runat="server" Text="Braga[1.2]x[3.15] Famalicão[2.15]" Visible="False"></asp:Label><br />
                <hr />
                <h3>Liga Fracesa</h3>
                <hr />
                <b><asp:Label ID="Label4" runat="server" Text="PSG[2.15] X[3.0] LYON[2.5]" Visible="False" Width="60"></asp:Label><br /></b>
                <asp:Label ID="Label5" runat="server" Text="PSG[2.15] X[3.0] LYON[2.5]" Visible="False"></asp:Label><br />
                <asp:Label ID="Label6" runat="server" Text="lille[1.2] x[3.15] Nimes[2.15]" Visible="False"></asp:Label><br />
                <hr />
                <h3>Liga Inglesa</h3>
                <hr />
                <b><asp:Label ID="Label7" runat="server" Text="Wolves[2.15] X[3.0] Leicester[2.5]" Visible="False"></asp:Label><br /></b>
                <asp:Label ID="Label8" runat="server" Text="Mun.City[2.15] X[3.0] Mun.United[2.5]" Visible="False"></asp:Label><br />
                <asp:Label ID="Label9" runat="server" Text="Arsenal[1.2] x[3.15] Newcastle[2.15]" Visible="False"></asp:Label><br />
                <br />
                <br />
                Confirme a sua identidade
                Nome:<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                Pass:<asp:TextBox ID="txtPass" runat="server" ></asp:TextBox>
                ID-><asp:TextBox ID="txtAID" runat="server"></asp:TextBox>
                Winner-><asp:TextBox ID="txtAW" runat="server"></asp:TextBox>
                Quantia<asp:TextBox ID="txtAQ" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Aposta" OnClick="Button1_Click" />
            </div>
		<!-- Footer -->
			<div id="footer">
                
				<!-- Copyright -->
					<ul class="copyright">
						<li>&copy; Untitled. All rights reserved. reserved.</li><li>Design: <a href="http://html5up.net">HTML5 UP</a></li>
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
    </form>
</html>