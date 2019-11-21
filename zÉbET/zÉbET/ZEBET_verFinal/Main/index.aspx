<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="zÉbET.index" %>

<!DOCTYPE html>
<html style="zoom:100%">
	<head>
		<title>ZÉ.BET | Site de Apostas</title>
		<meta charset="us-ascii" />
		<meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />
		<link rel="stylesheet" href="assets/css/main.css" />
	</head>
    <body class="is-preload">

        <!-- Header -->
        <div id="header">

            <div class="top">

                <!-- Logo -->
                <div id="logo">

                    <a href="#top" id="top-link"> <span class="image avatar48"><img src="images/appinventor.ai_robson_ppena.CARTOLA.png" alt="" /></span></a>
                    <a href="#top" id="A1"><h1 id="title">ZÉ.<a style="color: #ff6a00">BET</a></h1></a>
                    <p>Site de apostas</p>
                </div>

                <!-- Nav -->
                <nav id="nav">
                    <ul>
                        <li><a href="#top" id="A2"><span class="icon solid fa-home">Início</span></a></li>
                        <li><a href="#portfolio" id="portfolio-link"><span class="icon solid fa-trophy">Desportos</span></a></li>
                        <li><a href="#about" id="about-link"><span class="icon solid fa-question-circle">Ajuda</span></a></li>
                        <li><a href="#contact" id="contact-link"><span class="icon solid fa-envelope">Contacta-nos</span></a></li>
                        <li><a href="#register"><span class="icon solid fa-user">Login / Regista-te!</span></a></li>
                    </ul>
                </nav>
                <p>
                    <br /><br /><br /><br /><br /><br /><br />
                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label><br />
                    <asp:Label ID="Label6" runat="server" Text="" CssClass="left_align"></asp:Label>
                </p>

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

            <!-- Intro -->
            <section id="top" class="one dark cover">
                <div class="container">

                    <header id="wtf">
                        <h2 class="alt"><strong>Aposta na Desportiva.</strong></h2>
                        <a href="#portfolio" class="button scrolly button-top"><strong>Quero Apostar!</strong></a>

                    </header>

                </div>
            </section>

            <!-- Portfolio -->
            <section id="portfolio" class="two">
                <div class="container">

                    <header>
                        <h2><strong>Desportos</strong></h2>
                    </header>

                    <p>
                        <strong>
                            Aqui tens os teus desportos favoritos! Aposta já e ganha grandes prémios.
                            Os deportos estão divididos em futebol
                            , basquetebal, ténis, e muitos mais!
                        </strong> <br />
                    </p>
                    <p style="font-size:35px"><strong>A escolha é tua.</strong></p>

                    <div class="row">
                        <div class="col-4 col-12-mobile">
                            
                            <div class="cont">
                                <a href="DESPORTOS/futbol.aspx">
                                    <img src="images/pic02.jpg" alt=""
                                         class="vanish" />
                                </a>
                                <div class="mid">
                                        <div class="texttt">Futebol</div>
                                </div>
                                
                            </div>
                            <div class="cont">
                                <a href="DESPORTOS/tennis.aspx">
                                    <img src="images/pic03.jpg" alt=""
                                         class="vanish" />
                                </a>
                                <div class="mid">
                                    <div class="texttt">Ténis</div>
                                </div>
                            </div>
                        </div>
                        <div class="col-4 col-12-mobile">

                            <div class="cont">
                                <a href="DESPORTOS/Basket.aspx">
                                    <img src="images/pic04.jpg" alt=""
                                         class="vanish" />
                                </a>
                                <div class="mid">
                                    <div class="texttt">Basquetebol</div>
                                </div>
                            </div>

                            <div class="cont">
                                <a href="DESPORTOS/HoqueinoGelo.aspx">
                                    <img src="images/pic05.jpg" alt=""
                                         class="vanish" />
                                </a>
                                <div class="mid">
                                    <div class="texttt">Hóquei</div>
                                </div>
                            </div>

                        </div>
                        <div class="col-4 col-12-mobile">
                            <div class="cont">
                                <a href="DESPORTOS/Baseball.aspx">
                                    <img src="images/pic06.jpg" alt=""
                                         class="vanish" />
                                </a>
                                <div class="mid">
                                    <div class="texttt">Basebol</div>
                                </div>
                            </div>
                            <div class="cont">
                                <a href="DESPORTOS/snooker.aspx">
                                    <img src="images/pic07.jpg" alt=""
                                         class="vanish" />
                                </a>
                                <div class="mid">
                                    <div class="texttt">Snooker</div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </section>

            <!-- FAQ -->
            <section id="about" class="three">
                <div class="container">

                    <header>
                        <h2>Preciso de ajuda!</h2>
                    </header>
                    <h3>F.A.Q</h3>
                    <br />
                    <div>
                        <h4>Como registar-me?</h4>
                        <p>
                            Abrir uma conta no ZÉ.BET é gratuito e dá-lhe acesso a todo o site.
                            <br />
                            Aceda ao formulário de registo no painel esquerdo e
                            clique em “Regista-te!”.
                        </p>
                    </div>
                    <br />
                    <div>
                        <h4>Não me consigo registar. O que posso fazer?</h4>
                        <p>
                            Várias razões podem explicar esta situação:
                            <br />
                            - Você já possui uma conta ativa no ZÉ.BET.
                            <br />
                            - Poderá não conseguir completar o seu registo devido às
                            cookies do seu browser.
                            Queira, por favor, limpar a cache e as
                            cookies do browser ou escolher um diferente
                            para completar o seu registo.
                            <br />
                            - Os desenvolvedores deste site, devem ter-se esquecido de um ponto e vírgula no
                            desenvolvimento do código para tal.
                            Queira, por favor, ter paciência e aguardar.
                        </p>
                    </div>
                    <br />
                    <div>
                        <h4>É possível cancelar uma aposta já efectuada?</h4>
                        <p>
                            Não.
                            <br />
                            Uma vez validada uma aposta, não poderá solicitar o cancelamento.
                        </p>
                    </div>
                    <br />
                    <div>
                        <h4>Atingi o limite de apostas, o que poderei fazer?</h4>
                        <p>
                            O limite de apostas e o limite de
                            depósito foram estabelecidos para
                            proteger e oferecer aos nossos
                            jogadores um ambiente de jogo seguro e responsável.
                            <br />
                            Ao permitir que você defina os
                            seus próprios limites, pretendemos
                            permitir que você controle melhor as
                            suas despesas e o seu ritmo de jogo.
                            <br />
                            Neste caso, saiba que poderá definir e /
                            ou modificar os limites diários, semanais
                            e mensais na seção "Jogo Responsável" na sua conta.
                            <br />
                            Tenha em atenção que qualquer pedido feito para
                            aumentar ou remover um limite não terá efeito antes de 24 horas (1 dia).
                        </p>
                    </div>
                    <br />
                    <div>
                        <h4>Quais são os diferentes tipos de aposta ?</h4>
                        <p>
                            Pretendemos oferecer aos nossos
                            jogadores a melhor experiência de
                            apostas desportivas. Portanto,
                            cobrimos as ofertas básicas de apostas mas também muito mais.
                            <br />
                            Os principais tipos de aposta em ZÉ.BET
                            (Nota: A informação a seguir foi retirada do site de apostas Betclic.pt):
                            <br />
                            - A aposta "Simples": como o nome sugere,
                            esta aposta consiste em apostar em um único evento /
                            seleção. Se tiver o prognóstico correto, é uma vitória!
                            <br />
                            - A aposta "múltipla”: consiste em selecionar de 2 a 20 seleções
                            em um mesmo "Boletim".
                            O pagamento final é obtido multiplicando o valor
                            apostado pela multiplacação das odds das suas seleções.
                            Todos os prognósticos devem ser corretos para ganhar uma aposta "múltipla".
                            <br />
                            Bom saber: se, por qualquer motivo, uma seleção for anulada /
                            cancelada, a odd da sua aposta será recalculada com base nas restantes seleções.
                        </p>
                    </div>
                </div>
            </section>
            <!-- Contact -->
            <section id="contact" class="four">
                <div class="container">

                    <header>
                        <h2>Contacta-nos!</h2>
                    </header>

                    <p>
                        Elementum sem parturient nulla quam placerat viverra
                        mauris non cum elit tempus ullamcorper dolor. Libero rutrum ut lacinia
                        donec curae mus. Eleifend id porttitor ac ultricies lobortis sem nunc
                        orci ridiculus faucibus a consectetur. Porttitor curae mauris urna mi dolor.
                    </p>

                    <form method="post" action="#">
                        <div class="row">
                            <div class="col-6 col-12-mobile"><input type="text" name="name" placeholder="Name" /></div>
                            <div class="col-6 col-12-mobile"><input type="text" name="email" placeholder="Email" /></div>
                            <div class="col-12">
                                <textarea name="message" placeholder="Message"></textarea>
                            </div>
                            <div class="col-12">
                                <button type='submit' class="button-bottom">Enviar</button>
                            </div>
                        </div>
                    </form>

                </div>
            </section>



            <!-- REGISTER -->
            <section id="register" class="five">
                <form id="registerform" runat="server">

                     <asp:Label font-size="70px" ID="lblRegista" runat="server" Text="Regista-te!"></asp:Label><br /><br />
                     Username<asp:TextBox ID="txtUtilizador" runat="server" ></asp:TextBox>
                    <asp:Label ID="lblUtilizador" runat="server" Text="" Visible="False" ForeColor="Red"></asp:Label>  <br />
                     Password<asp:TextBox ID="txtPassword" TextMode= "Password" runat="server" ></asp:TextBox><br />
                    <label for='form-switch'><asp:Label ID="errorLabel" runat="server" Text="Label" ForeColor="#CC0000" Visible="False"></asp:Label><br />
                    </label>
                    Confirma a Password<asp:TextBox ID="txtRePassword" TextMode= "Password" runat="server" ></asp:TextBox>   
                    <asp:Label ID="lblMatchPass" runat="server" Text="" Visible="False" ForeColor="Red"></asp:Label>        <br />         
                    <br />
            <%--        <asp:TextBox ID="txtUtilizadorLogin" runat="server" ></asp:TextBox>
                    <asp:TextBox ID="txtPasswordLogin" TextMode= "Password" runat="server" ></asp:TextBox> 
                   <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

                    <label for='form-switch'><span>Regista-te</span></label>--%>
                    <asp:Button ID="btnRegista" runat="server" Text="Regista-te" OnClick="btnRegista_Click" /><br /><br /><br />
                   <%-- Login --%>  
                    <asp:Label font-size="70px" ID="Label1" runat="server" Text="Login"></asp:Label><br /><br />    
                     Username<asp:TextBox ID="txtUsernameL" runat="server" ></asp:TextBox>
                     Password<asp:TextBox ID="txtPassowordL" TextMode= "Password" runat="server" ></asp:TextBox>
                    <asp:Label ID="Label4" runat="server" Text="" Visible="False" ForeColor="Red"></asp:Label>   <br />    <br />
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"  /><br /><br /><br />

                    </form>
            </section>

        </div>
        <!-- Footer -->
        <div id="footer">

            <!-- Copyright -->
            <ul class="copyright">
                <li>&copy; Untitled. All rights reserved.</li>
                <li>Design: HTML5 UP | Gonçalo Vidal | Tomás Dias | TGPSI17 01</a></li>
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