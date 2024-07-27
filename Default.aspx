<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BAHRAIN_TOURS.Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Bahrain Tours</title>
    <link rel="stylesheet" href="css/normalize.css" />
    <link rel="stylesheet" href="css/elzero.css" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="css/all.min.css" />
    <!-- Google Fonts -->
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Cairo:wght@300;400;700&display=swap" rel="stylesheet" />
</head>
<body>
    <form action="" runat="server">
        <!-- Start Header -->
        <div class="header" id="header">
            <div class="container">
                <a href="Default.aspx" class="logo">Bahrain Tours</a>

                <ul class="main-nav">
                    <li><a href="#Booking">Booking</a></li>
                    <li><a href="#Trips">Trips</a></li>
                    <li><a href="#features">Features</a></li>
                    <li><a href="login_person.aspx">Login</a></li>
                    <li><a href="logout.aspx">Logout</a></li>
                    <li><a href="signup_person.aspx">Signup</a></li>
                    <li>
                        <a href="#">Other Links</a>
                        <!-- Start Megamenu -->
                        <div class="mega-menu">
                            <div class="image">
                                <img src="imgs/megamenu.png" alt="" />
                            </div>
                            <ul class="links">
                                <li>
                                    <a href="#testimonials"><i class="far fa-comments fa-fw"></i>Testimonials</a>
                                </li>
                                <li>
                                    <a href="#team"><i class="far fa-user fa-fw"></i>Team Members</a>
                                </li>
                                <li>
                                    <a href="#services"><i class="far fa-building fa-fw"></i>Services</a>
                                </li>
                                <li>
                                    <a href="#events"><i class="far fa-calendar-alt fa-fw"></i>Events</a>
                                </li>
                                <li>
                                    <a href="#pricing"><i class="fas fa-server fa-fw"></i>Pricing Plans</a>
                                </li>
                            </ul>
                            <ul class="links">
                                <li>
                                    <a href="profile_person.aspx"><i class="far fa-chart-bar fa-fw"></i>Profile</a>
                                </li>
                                <li>
                                    <a href="#discount"><i class="fas fa-percent fa-fw"></i>Contact Us</a>
                                </li>
                                <li>
                                    <a href="signup_company.aspx"><i class="far fa-play-circle fa-fw"></i>Signup (company)</a>
                                </li>
                                <li>
                                    <a href="login_company.aspx"><i class="far fa-chart-bar fa-fw"></i>Login (company)</a>
                                </li>
                                <li>
                                    <a href="logout.aspx"><i class="fas fa-percent fa-fw"></i>Logout</a>
                                </li>
                            </ul>
                        </div>
                        <!-- End Megamenu -->
                    </li>
                </ul>

                <ul class="main-nav" runat="server" id="admin_area">
                    <li>
                        <a href="#">Admin Area</a>
                        <!-- Start Megamenu -->
                        <div class="mega-menu">
                            <div class="image">
                                <img src="imgs/megamenu.png" alt="" />
                            </div>
                            <ul class="links">
                                <li>
                                    <a href="users.aspx"><i class="far fa-comments fa-fw"></i>Users Table</a>
                                </li>
                                <li>
                                    <a href="companies.aspx"><i class="far fa-user fa-fw"></i>Company Table</a>
                                </li>
                                <li>
                                    <a href="tour.aspx"><i class="far fa-building fa-fw"></i>Tour Page</a>
                                </li>
                                <li>
                                    <a href="Review.aspx"><i class="far fa-check-circle fa-fw"></i>Review Page</a>
                                </li>
                                <li>
                                    <a href="Tourist.aspx"><i class="far fa-clipboard fa-fw"></i>Tourist Table</a>
                                </li>
                            </ul>
                            <ul class="links">
                                <li>
                                    <a href="contact_table.aspx"><i class="far fa-calendar-alt fa-fw"></i>Contact Table</a>
                                </li>
                                <li>
                                    <a href="booking_table.aspx"><i class="fas fa-server fa-fw"></i>Booking Table</a>
                                </li>
                                <li>
                                    <a href="companies_table.aspx"><i class="far fa-play-circle fa-fw"></i>Companies Table</a>
                                </li>
                                <li>
                                    <a href="profile.aspx"><i class="far fa-chart-bar fa-fw"></i>Profile</a>
                                </li>
                                <li>
                                    <a href="#"><i class="fas fa-percent fa-fw"></i>Link</a>
                                </li>
                            </ul>
                        </div>
                        <!-- End Megamenu -->
                    </li>
                </ul>
            </div>
        </div>
        <!-- End Header -->
        <!-- Start Landing -->
        <div class="landing">
            <div class="container">
                <div class="text">
                    <h1>Welcome To Bahrain Tours World</h1>
                    <p>Here you will enjoy every time, our Bahrain Tours web site offers you a lot of services</p>
                </div>
                <div class="image">
                    <img src="imgs/landing-image.png" alt="" />
                </div>
            </div>
            <a href="#articles" class="go-down">
                <i class="fas fa-angle-double-down fa-2x"></i>
            </a>
        </div>
        <!-- End Landing -->
        <!-- Start Articles -->

        <div class="articles" id="Booking">
            <h2 class="main-title">Booking NOW !!</h2>
            <div class="container">
                <div class="box">
                    <img src="imgs/01.png" alt="" />
                    <div class="content">
                        <asp:Label ID="lblMuseum" runat="server" Text="Museum">Museum</asp:Label>
                        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Reprehenderit</p>
                        <span><strong>Price : </strong></span>
                        <asp:Label ID="lblPriceMuseum" runat="server" Text="30 BD" ForeColor="#0066FF">30 BD</asp:Label>
                    </div>
                    <div class="info">
                        <asp:Button ID="btnMuseum" runat="server" Text="Booking Now !!" OnClick="btnMuseum_Click" />
                        <i class="fas fa-long-arrow-alt-right"></i>
                    </div>
                </div>
                <div class="box">
                    <img src="imgs/02.jpeg" alt="" />
                    <div class="content">
                        <asp:Label ID="lblDive" runat="server" Text="Dive">Dive</asp:Label>
                        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Reprehenderit</p>
                        <span><strong>Price : </strong></span>
                        <asp:Label ID="lblPriceDive" runat="server" Text="60 BD" ForeColor="#0066FF">60 BD</asp:Label>
                    </div>
                    <div class="info">
                        <asp:Button ID="btnDive" runat="server" Text="Booking Now !!" OnClick="btnDive_Click" />
                        <i class="fas fa-long-arrow-alt-right"></i>
                    </div>
                </div>
                <div class="box">
                    <img src="imgs/03.jpeg" alt="" />
                    <div class="content">
                        <asp:Label ID="lblJetpack" runat="server" Text="Jetpack">Jetpack</asp:Label>
                        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Reprehenderit</p>
                        <span><strong>Price : </strong></span>
                        <asp:Label ID="lblPriceJetpack" runat="server" Text="50 BD" ForeColor="#0066FF">50 BD</asp:Label>
                    </div>
                    <div class="info">
                        <asp:Button ID="btnJetpack" runat="server" Text="Booking Now !!" OnClick="btnJetpack_Click" />
                        <i class="fas fa-long-arrow-alt-right"></i>
                    </div>
                </div>
                <div class="box">
                    <img src="imgs/04.jpeg" alt="" />
                    <div class="content">
                        <asp:Label ID="lblWahooo" runat="server" Text="Wahooo">Wahooo</asp:Label>
                        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Reprehenderit</p>
                        <span><strong>Price : </strong></span>
                        <asp:Label ID="lblPriceWahooo" runat="server" Text="20 BD" ForeColor="#0066FF">20 BD</asp:Label>
                    </div>
                    <div class="info">
                        <asp:Button ID="btnWahooo" runat="server" Text="Booking Now !!" OnClick="btnWahooo_Click" />
                        <i class="fas fa-long-arrow-alt-right"></i>
                    </div>
                </div>
                <div class="box">
                    <img src="imgs/05.jpeg" alt="" />
                    <div class="content">
                        <asp:Label ID="lblKarting" runat="server" Text="Karting">Karting</asp:Label>
                        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Reprehenderit</p>
                        <span><strong>Price : </strong></span>
                        <asp:Label ID="lblPriceKarting" runat="server" Text="30 BD" ForeColor="#0066FF">30 BD</asp:Label>
                    </div>
                    <div class="info">
                        <asp:Button ID="btnKarting" runat="server" Text="Booking Now !!" OnClick="btnKarting_Click" />
                        <i class="fas fa-long-arrow-alt-right"></i>
                    </div>
                </div>
                <div class="box">
                    <img src="imgs/06.png" alt="" />
                    <div class="content">
                        <asp:Label ID="lblDilmun" runat="server" Text="Dilmun">Dilmun</asp:Label>
                        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Reprehenderit</p>
                        <span><strong>Price : </strong></span>
                        <asp:Label ID="lblPriceDilmun" runat="server" Text="15 BD" ForeColor="#0066FF">15 BD</asp:Label>
                    </div>
                    <div class="info">
                        <asp:Button ID="btnDilmun" runat="server" Text="Booking Now !!" OnClick="btnDilmun_Click" />
                        <i class="fas fa-long-arrow-alt-right"></i>
                    </div>
                </div>
                <div class="box">
                    <img src="imgs/07.png" alt="" />
                    <div class="content">
                        <asp:Label ID="lblBabBahrain" runat="server" Text="BabBahrain">BabBahrain</asp:Label>
                        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Reprehenderit</p>
                        <span><strong>Price : </strong></span>
                        <asp:Label ID="lblPriceBabBahrain" runat="server" Text="10 BD" ForeColor="#0066FF">10 BD</asp:Label>
                    </div>
                    <div class="info">
                        <asp:Button ID="btnBabBahrain" runat="server" Text="Booking Now !!" OnClick="btnBabBahrain_Click" />
                        <i class="fas fa-long-arrow-alt-right"></i>
                    </div>
                </div>
                <div class="box">
                    <img src="imgs/01.png" alt="" />
                    <div class="content">
                        <asp:Label ID="lblQalatAlBahrain" runat="server" Text="QalatAlBahrain">QalatAlBahrain</asp:Label>
                        <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Reprehenderit</p>
                        <span><strong>Price : </strong></span>
                        <asp:Label ID="lblPriceQalatAlBahrain" runat="server" Text="7 BD" ForeColor="#0066FF">7 BD</asp:Label>
                    </div>
                    <div class="info">
                        <asp:Button ID="btnQalatAlBahrain" runat="server" Text="Booking Now !!" OnClick="btnQalatAlBahrain_Click" />
                        <i class="fas fa-long-arrow-alt-right"></i>
                    </div>
                </div>


            </div>
        </div>
        <div class="spikes"></div>

        <!-- End Articles -->
        <!-- Start Gallery -->
        <div class="gallery" id="Trips">
            <h2 class="main-title">Trips</h2>
            <div class="container">
                <div class="box">
                    <div class="image">
                        <img src="imgs/01.png" alt="" />
                    </div>
                </div>
                <div class="box">
                    <div class="image">
                        <img src="imgs/02.jpeg" alt="" />
                    </div>
                </div>
                <div class="box">
                    <div class="image">
                        <img src="imgs/03.jpeg" alt="" />
                    </div>
                </div>
                <div class="box">
                    <div class="image">
                        <img src="imgs/04.jpeg" alt="" />
                    </div>
                </div>
                <div class="box">
                    <div class="image">
                        <img src="imgs/05.jpeg" alt="" />
                    </div>
                </div>
                <div class="box">
                    <div class="image">
                        <img src="imgs/06.png" alt="" />
                    </div>
                </div>
            </div>
        </div>
        <!-- End Gallery -->
        <!-- Start Features -->
        <div class="features" id="features">
            <h2 class="main-title">Features</h2>
            <div class="container">
                <div class="box quality">
                    <div class="img-holder">
                        <img src="imgs/01.png" alt="" />
                    </div>
                    <h2>Quality</h2>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit harum hic veniam eligendi minima</p>
                    
                </div>
                <div class="box time">
                    <div class="img-holder">
                        <img src="imgs/02.jpeg" alt="" />
                    </div>
                    <h2>Time</h2>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit harum hic veniam eligendi minima</p>
                    
                </div>
                <div class="box passion">
                    <div class="img-holder">
                        <img src="imgs/03.jpeg" alt="" />
                    </div>
                    <h2>Entertainment</h2>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit harum hic veniam eligendi minima</p>
                    
                </div>
            </div>
        </div>
        <!-- End Features -->
        <!-- Start Testimonials -->
        <div class="testimonials" id="testimonials">
            <h2 class="main-title">Testimonials</h2>
            <div class="container">
                <div class="box">
                    <img src="imgs/avatar-01.png" alt="" />
                    <h3>Mohamed Farag</h3>
                    <span class="title">Tourist</span>
                    <div class="rate">
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="far fa-star"></i>
                    </div>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Maiores et reiciendis voluptatum, amet est natus
            quaerat ducimus
                    </p>
                </div>
                <div class="box">
                    <img src="imgs/avatar-02.png" alt="" />
                    <h3>Mohamed Ibrahim</h3>
                    <span class="title">Tourist</span>
                    <div class="rate">
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="far fa-star"></i>
                    </div>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Maiores et reiciendis voluptatum, amet est natus
            quaerat ducimus
                    </p>
                </div>
                <div class="box">
                    <img src="imgs/avatar-03.png" alt="" />
                    <h3>Shady Nabil</h3>
                    <span class="title">Tourist</span>
                    <div class="rate">
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="far fa-star"></i>
                    </div>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Maiores et reiciendis voluptatum, amet est natus
            quaerat ducimus
                    </p>
                </div>
                <div class="box">
                    <img src="imgs/avatar-04.png" alt="" />
                    <h3>Amr Hendawy</h3>
                    <span class="title">Tourist</span>
                    <div class="rate">
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                    </div>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Maiores et reiciendis voluptatum, amet est natus
            quaerat ducimus
                    </p>
                </div>
                <div class="box">
                    <img src="imgs/avatar-05.png" alt="" />
                    <h3>Sherief Ashraf</h3>
                    <span class="title">Tourist</span>
                    <div class="rate">
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="far fa-star"></i>
                        <i class="far fa-star"></i>
                    </div>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Maiores et reiciendis voluptatum, amet est natus
            quaerat ducimus
                    </p>
                </div>
                <div class="box">
                    <img src="imgs/avatar-06.png" alt="" />
                    <h3>Osama Mohamed</h3>
                    <span class="title">Tourist</span>
                    <div class="rate">
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="filled fas fa-star"></i>
                        <i class="far fa-star"></i>
                        <i class="far fa-star"></i>
                    </div>
                    <p>
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Maiores et reiciendis voluptatum, amet est natus
            quaerat ducimus
                    </p>
                </div>
            </div>
        </div>
        <!-- End Testimonials -->
        <!-- Start Team -->
        <div class="team" id="team">
            <h2 class="main-title">Team Members</h2>
            <div class="container">
                <div class="box">
                    <div class="data">
                        <img src="imgs/avatar-01.png" alt="" />
                        <div class="social">
                            <a href="#">
                                <i class="fab fa-facebook-f"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-twitter"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-linkedin-in"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-youtube"></i>
                            </a>
                        </div>
                    </div>
                    <div class="info">
                        <h3>Ahmed</h3>
                        <p>Simple Short Description</p>
                    </div>
                </div>
                <div class="box">
                    <div class="data">
                        <img src="imgs/avatar-02.png" alt="" />
                        <div class="social">
                            <a href="#">
                                <i class="fab fa-facebook-f"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-twitter"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-linkedin-in"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-youtube"></i>
                            </a>
                        </div>
                    </div>
                    <div class="info">
                        <h3>Ali</h3>
                        <p>Simple Short Description</p>
                    </div>
                </div>
                <div class="box">
                    <div class="data">
                        <img src="imgs/avatar-03.png" alt="" />
                        <div class="social">
                            <a href="#">
                                <i class="fab fa-facebook-f"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-twitter"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-linkedin-in"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-youtube"></i>
                            </a>
                        </div>
                    </div>
                    <div class="info">
                        <h3>Omar</h3>
                        <p>Simple Short Description</p>
                    </div>
                </div>
                <div class="box">
                    <div class="data">
                        <img src="imgs/avatar-04.png" alt="" />
                        <div class="social">
                            <a href="#">
                                <i class="fab fa-facebook-f"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-twitter"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-linkedin-in"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-youtube"></i>
                            </a>
                        </div>
                    </div>
                    <div class="info">
                        <h3>Mohamed</h3>
                        <p>Simple Short Description</p>
                    </div>
                </div>
                <div class="box">
                    <div class="data">
                        <img src="imgs/avatar-05.png" alt="" />
                        <div class="social">
                            <a href="#">
                                <i class="fab fa-facebook-f"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-twitter"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-linkedin-in"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-youtube"></i>
                            </a>
                        </div>
                    </div>
                    <div class="info">
                        <h3>Adel</h3>
                        <p>Simple Short Description</p>
                    </div>
                </div>
                <div class="box">
                    <div class="data">
                        <img src="imgs/avatar-06.png" alt="" />
                        <div class="social">
                            <a href="#">
                                <i class="fab fa-facebook-f"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-twitter"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-linkedin-in"></i>
                            </a>
                            <a href="#">
                                <i class="fab fa-youtube"></i>
                            </a>
                        </div>
                    </div>
                    <div class="info">
                        <h3>Khaled</h3>
                        <p>Simple Short Description</p>
                    </div>
                </div>
                <!--
            <div class="box">
                <div class="data">
                    <img src="imgs/team-07.jpg" alt="" />
                    <div class="social">
                        <a href="#">
                            <i class="fab fa-facebook-f"></i>
                        </a>
                        <a href="#">
                            <i class="fab fa-twitter"></i>
                        </a>
                        <a href="#">
                            <i class="fab fa-linkedin-in"></i>
                        </a>
                        <a href="#">
                            <i class="fab fa-youtube"></i>
                        </a>
                    </div>
                </div>
                <div class="info">
                    <h3>Name</h3>
                    <p>Simple Short Description</p>
                </div>
            </div>
            <div class="box">
                <div class="data">
                    <img src="imgs/team-08.jpg" alt="" />
                    <div class="social">
                        <a href="#">
                            <i class="fab fa-facebook-f"></i>
                        </a>
                        <a href="#">
                            <i class="fab fa-twitter"></i>
                        </a>
                        <a href="#">
                            <i class="fab fa-linkedin-in"></i>
                        </a>
                        <a href="#">
                            <i class="fab fa-youtube"></i>
                        </a>
                    </div>
                </div>
                <div class="info">
                    <h3>Name</h3>
                    <p>Simple Short Description</p>
                </div>
            </div>
            -->
            </div>
        </div>
        <div class="spikes"></div>
        <!-- End Team -->
        <!-- Start Services -->
        <div class="services" id="services">
            <h2 class="main-title">Services</h2>
            <div class="container">
                <div class="box">
                    <i class="fas fa-user-shield fa-4x"></i>
                    <h3>Service 1</h3>
                    <div class="info">
                        <a href="#">Details</a>
                    </div>
                </div>
                <div class="box">
                    <i class="fas fa-tools fa-4x"></i>
                    <h3>Service 2</h3>
                    <div class="info">
                        <a href="#">Details</a>
                    </div>
                </div>
                <div class="box">
                    <i class="fas fa-map-marked-alt fa-4x"></i>
                    <h3>Service 3</h3>
                    <div class="info">
                        <a href="#">Details</a>
                    </div>
                </div>
                <div class="box">
                    <i class="fas fa-laptop-code fa-4x"></i>
                    <h3>Service 4</h3>
                    <div class="info">
                        <a href="#">Details</a>
                    </div>
                </div>
                <div class="box">
                    <i class="fas fa-palette fa-4x"></i>
                    <h3>Service 5</h3>
                    <div class="info">
                        <a href="#">Design</a>
                    </div>
                </div>
                <div class="box">
                    <i class="fas fa-bullhorn fa-4x"></i>
                    <h3>Service 6</h3>
                    <div class="info">
                        <a href="#">Details</a>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Services -->
        
        <!-- Start Events 
        <div class="events" id="events">
            <div class="dots dots-up"></div>
            <div class="dots dots-down"></div>
            <h2 class="main-title">Latest Events</h2>
            <div class="container">
                <img src="imgs/events.png" alt="" />
                <div class="info">
                    <div class="time">
                        <div class="unit">
                            <span class="days">01</span>
                            <span>Days</span>
                        </div>
                        <div class="unit">
                            <span class="hours">01</span>
                            <span>Hours</span>
                        </div>
                        <div class="unit">
                            <span class="minutes">00</span>
                            <span>Minutes</span>
                        </div>
                        <div class="unit">
                            <span class="seconds">00</span>
                            <span>Seconds</span>
                        </div>
                    </div>
                    <h2 class="title">Tech Masters Event 2021</h2>
                    <p class="description">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Et vero tenetur doloremque iusto ut adipisci quam
            ratione aliquam excepturi nulla in harum, veritatis porro
                    </p>
                </div>
            </div>
        </div>
         End Events -->
        <!-- Start Pricing -->
        <div class="pricing" id="pricing">
            <div class="dots dots-up"></div>
            <div class="dots dots-down"></div>
            <h2 class="main-title">Pricing Plans</h2>
            <div class="container">
                <div class="box">
                    <div class="title">Basic</div>
                    <img src="imgs/hosting-basic.png" alt="" />
                    <div class="price">
                        <span class="amount">$100</span>
                        <span class="time">Per year</span>
                    </div>
                    <ul>
                        <li>Feature 01</li>
                        <li>Feature 02</li>
                        <li>Feature 03</li>
                        <li>Feature 04</li>
                        <li>Feature 05</li>
                    </ul>
                    <a href="#">Choose Plan</a>
                </div>
                <div class="box popular">
                    <div class="label">Most Popular</div>
                    <div class="title">Gold</div>
                    <img src="imgs/hosting-advanced.png" alt="" />
                    <div class="price">
                        <span class="amount">$200</span>
                        <span class="time">Per Year</span>
                    </div>
                    <ul>
                        <li>Feature 01</li>
                        <li>Feature 02</li>
                        <li>Feature 03</li>
                        <li>Feature 04</li>
                        <li>Feature 05</li>
                    </ul>
                    <a href="#">Choose Plan</a>
                </div>
                <div class="box">
                    <div class="title">Premium</div>
                    <img src="imgs/hosting-professional.png" alt="" />
                    <div class="price">
                        <span class="amount">$400</span>
                        <span class="time">Per Year</span>
                    </div>
                    <ul>
                        <li>Feature 01</li>
                        <li>Feature 02</li>
                        <li>Feature 03</li>
                        <li>Feature 04</li>
                        <li>Feature 05</li>
                    </ul>
                    <a href="#">Choose Plan</a>
                </div>
            </div>
        </div>
        <!-- End Pricing -->

        <!-- Start Discount -->
        <div class="discount" id="discount">
            <div class="image">
                <div class="content">
                    <h2>You Can Contact Us Now !!</h2>
                    <p>
                        Lorem ipsum dolor sit amet consectetur, adipisicing elit. Excepturi asperiores consectetur, recusandae
            ratione provident necessitatibus, cumque delectus commodi fuga praesentium beatae. Totam vel similique
            laborum dicta aperiam odit doloribus corporis.
                    </p>
                    <img src="imgs/discount.png" alt="" />
                </div>
            </div>
            <div class="form">
                <div class="content">
                    <h2>You Can Contact Us Now !!</h2>

                    <asp:TextBox class="input" ID="txtName" runat="server" placeholder="Your Name"></asp:TextBox>
                    <asp:TextBox class="input" ID="txtEmail" runat="server" placeholder="Your Email"></asp:TextBox>
                    <asp:TextBox class="input" ID="txtPhone" runat="server" placeholder="Your Phone"></asp:TextBox>
                    <textarea class="input" id="txtMsg" cols="20" rows="4" runat="server" placeholder="Tell Us About Your Problem"></textarea>
                    <asp:Button ID="btnSubmit" runat="server" Text="Send" OnClick="btnSubmit_Click" />
                </div>
            </div>
        </div>
        <!-- End Discount -->
        <!-- Start Footer -->
        <div class="footer">
            <div class="container">
                <div class="box">
                    <h3>Bahrain Tours</h3>
                    <ul class="social">
                        <li>
                            <a href="#" class="facebook">
                                <i class="fab fa-facebook-f"></i>
                            </a>
                        </li>
                        <li>
                            <a href="#" class="twitter">
                                <i class="fab fa-twitter"></i>
                            </a>
                        </li>
                        <li>
                            <a href="#" class="youtube">
                                <i class="fab fa-youtube"></i>
                            </a>
                        </li>
                    </ul>
                    <p class="text">
                        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Temporibus nulla rem, dignissimos iste aspernatur
                    </p>
                </div>
                <div class="box">
                    <ul class="links">
                        <li><a href="login_person.aspx">Login</a></li>
                        <li><a href="signup_person.aspx">Sign Up</a></li>
                        <li><a href="#">Important Link 1</a></li>
                        <li><a href="#">Important Link 2</a></li>
                        <li><a href="#">Important Link 3</a></li>
                    </ul>
                </div>
                <div class="box">
                    <div class="line">
                        <i class="fas fa-map-marker-alt fa-fw"></i>
                        <div class="info">Bahrain, Aali , Arab Open University - Bahrain Street 3220, Building 890, Block 732, A'ali</div>
                    </div>
                    <div class="line">
                        <i class="far fa-clock fa-fw"></i>
                        <div class="info">Business Hours: From 10:00 To 18:00</div>
                    </div>
                    <div class="line">
                        <i class="fas fa-phone-volume fa-fw"></i>
                        <div class="info">
                            <span>+973 3994 6677</span>
                            <span>+973 17407568</span>
                        </div>
                    </div>
                </div>
                <div class="box footer-gallery">
                    <img src="imgs/01.png" alt="" />
                    <img src="imgs/02.jpeg" alt="" />
                    <img src="imgs/03.jpeg" alt="" />
                    <img src="imgs/04.jpeg" alt="" />
                    <img src="imgs/05.jpeg" alt="" />
                    <img src="imgs/06.png" alt="" />
                </div>
            </div>
            <p class="copyright">Created by Bahrain Tours</p>
        </div>
        <!-- End Footer -->
    </form>
    <script src="js/main.js"></script>
</body>
</html>