* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: "Oleo Script Swash Caps";
}

ul,
ol {
  list-style: none;
}

a {
  text-decoration: none;
  color: #e798ce;
}
a:hover {
  color: #eccf0a;
}

button {
  padding: 8px 12px;
  margin: 8px 8px 8px;
  font-family: Roboto;
  font-weight: 600;
  border: 2px solid rgb(203, 7, 6);
  background: rgba(77, 49, 86, 0.724);
  color: #98e7b1;
  cursor: pointer;
  transition: all 0.3s;
  align-self: auto;
  margin-top: auto;
  border-radius: 20px;
}
button:hover {
  background: #4a325a;
  color: #eccf0a;
}

/*---- HEADER ----*/
header {
  background: #4a325a;
  border-bottom: 4px solid rgb(236, 207, 10);
  display: flex;
  flex-direction: column;
  font-family: "Oleo Script Swash Caps";
  width: 100%;
}
header div {
  display: flex;
  flex-direction: row;
  justify-content: space-evenly;
}
header div h1 {
  background-image: url("../assets/img/backgroundresized.jpg");
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  text-shadow: -3px -4px #eccf0a, -1px -2px #4a325a;
  font-size: 3.2rem;
  color: transparent;
  font-family: "Oleo Script Swash Caps";
  font-weight: 600;
  padding: 0px;
  letter-spacing: -3px;
  margin-left: 10vw;
}
header div h1 span {
  text-shadow: -3px -4px #98e7b1, -1px -2px #4a325a;
  font-size: 2.1rem;
  letter-spacing: -1px;
  text-align: start;
}
header div nav {
  margin-left: auto;
  align-self: flex-end;
}
header div nav ul {
  display: flex;
  justify-content: center;
  margin-right: 10vw;
}
header div nav ul li {
  font-size: 0.85rem;
  margin-bottom: 2vh;
  margin-left: 2vw;
}
header div nav ul li svg {
  color: #00b180;
}
header .header__divImg {
  align-self: flex-start;
  --g-red: #d04b36;
  --g-orange: #e36511;
  --g-yellow: #ffba00;
  --g-green: #00b180;
  --g-blue: #147aab;
  --g-indigo: #675997;
  /*background: linear-gradient(90deg, rgba(236,207,10,1) 5%, rgba(152,231,177,1) 10%, rgba(231,152,206,1) 23%);*/
  background: linear-gradient(var(--g-red) 0%, var(--g-red) 16.6666%, var(--g-orange) 16.6666%, var(--g-orange) 33.333%, var(--g-yellow) 33.333%, var(--g-yellow) 50%, var(--g-green) 50%, var(--g-green) 66.6666%, var(--g-blue) 66.6666%, var(--g-blue) 83.3333%, var(--g-indigo) 83.3333%, var(--g-indigo) 100%);
  width: 100%;
  padding: 2px;
}
header .header__divImg a {
  display: flex;
  flex-direction: row;
  justify-content: right;
  margin-right: 2.5rem;
  gap: 25px;
  color: #4a325a;
  margin-right: 10vw;
}
@media (max-width: 1000px) {
  header {
    flex-wrap: wrap;
    padding: 0px;
  }
  header div {
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }
  header div h1 {
    font-size: 4rem;
    margin: 0px;
  }
  header div h1 span {
    font-size: 3rem;
  }
  header div nav {
    width: 100%;
  }
  header div nav ul {
    justify-content: space-around;
    margin: 0;
  }
  header div nav ul li {
    margin: 0;
  }
  header div nav ul li span {
    visibility: hidden;
    display: none;
  }
  header .header__divImg a {
    justify-content: center;
    margin-right: 0;
  }
}
body {
  height: 85vh;
}

footer {
  text-align: center;
  justify-self: end;
  --g-red: #d04b36;
  --g-orange: #e36511;
  --g-yellow: #ffba00;
  --g-green: #00b180;
  --g-blue: #147aab;
  --g-indigo: #675997;
  /*background: linear-gradient(90deg, rgba(236,207,10,1) 5%, rgba(152,231,177,1) 10%, rgba(231,152,206,1) 23%);*/
  background: linear-gradient(var(--g-red) 0%, var(--g-red) 16.6666%, var(--g-orange) 16.6666%, var(--g-orange) 33.333%, var(--g-yellow) 33.333%, var(--g-yellow) 50%, var(--g-green) 50%, var(--g-green) 66.6666%, var(--g-blue) 66.6666%, var(--g-blue) 83.3333%, var(--g-indigo) 83.3333%, var(--g-indigo) 100%);
}
footer p {
  font-family: Roboto;
  font-size: 0.8rem;
}
footer p a {
  text-shadow: #eccf0a;
}

.form {
  width: 440px;
  height: 470px;
  background: #eccf0a;
  border-radius: 8px;
  box-shadow: 0 0 40px -10px #000;
  padding: 20px 30px;
  max-width: calc(100vw - 40px);
  position: relative;
}
.form h2 {
  margin: 10px 0;
  padding-bottom: 10px;
  width: 180px;
  color: #4a325a;
  border-bottom: 3px solid #78788c;
  font-family: Roboto;
}
.form p:before {
  content: attr(type);
  display: block;
  margin: 28px 0 0;
  font-size: 14px;
  color: #4a325a;
}
.form input {
  width: 100%;
  padding: 10px;
  box-sizing: border-box;
  background: none;
  outline: none;
  resize: none;
  border: 0;
  font-family: Roboto;
  transition: all 0.3s;
  border-bottom: 2px solid #bebed2;
}
.form input:focus {
  border-bottom: 2px solid #4a325a;
}
.form .button {
  float: right;
  padding: 8px 12px;
  margin: 8px 0 0;
  font-family: Roboto;
  border: 2px solid #78788c;
  background: 0;
  color: #5a5a6e;
  cursor: pointer;
  transition: all 0.3s;
}
.form .button:hover {
  background: #4a325a;
  color: #fff;
}
.form div {
  content: "Hi";
  position: absolute;
  bottom: -15px;
  right: -20px;
  background: #4a325a;
  color: #fff;
  width: 320px;
  padding: 16px 4px 16px 0;
  border-radius: 6px;
  font-size: 13px;
  box-shadow: 10px 10px 40px -14px #000;
}
.form div span {
  margin: 5px;
  font-family: Roboto;
  color: #e798ce;
}

/*----------------------- INDEX ----------------------*/
/*--- MAIN ---*/
.mainIndex {
  border-top: 2px solid #06cacb;
  display: flex;
  flex-direction: column;
  margin-bottom: 10px;
  /*--- HERO SECTION ---*/
  /*--- SECTION ---*/
}
.mainIndex .hero_section {
  width: 100%;
  background-image: url("../assets/img/bckgwp.png"), linear-gradient(90deg, #128C7E 0%, #128C7E 25%, #075E54 25%, #075E54 50%, #25D366 50%, #25D366 75%, #DCF8C6 75%, #DCF8C6 100%);
  background-repeat: no-repeat;
  background-position-x: center;
  background-position-y: center;
  display: flex;
  flex-direction: column;
  height: 30vh;
}
.mainIndex .hero_section__titulo {
  display: flex;
  flex-direction: row;
  justify-content: center;
  font-size: 4rem;
  align-items: baseline;
}
.mainIndex .hero_section__titulo h2 {
  color: white;
  text-shadow: 3px 3px 0px rgb(0, 0, 0), 0px 1px 5px rgb(0, 0, 0);
}
.mainIndex .hero_section__titulo svg {
  width: 64px;
  height: 64px;
}
.mainIndex .hero_section__instrucciones {
  display: flex;
  flex: row;
  height: 200px;
}
.mainIndex .hero_section__instrucciones div {
  display: flex;
  flex-direction: column;
  width: 25vw;
}
.mainIndex .hero_section__instrucciones div p {
  font-family: roboto;
  font-weight: bold;
  text-align: center;
}
.mainIndex .hero_section__instrucciones div svg {
  width: 48px;
  height: 48px;
  margin: 0;
}
.mainIndex .hero_section__instrucciones div .bi-cart-plus {
  margin-bottom: 12px;
  color: #eccf0a;
}
.mainIndex .hero_section__instrucciones div .bi-cart-plus-fill {
  margin-bottom: 12px;
  color: #00b180;
}
.mainIndex .hero_section__instrucciones div .bi-check2-all-grey {
  color: grey;
}
.mainIndex .hero_section__instrucciones div .bi-check2-all-blue {
  color: #34B7F1;
}
.mainIndex .section {
  display: flex;
  flex-direction: row;
  align-self: center;
  width: 80vw;
  box-shadow: 0 0 40px -10px #000;
  /*--- SLIDER ---*/
}
.mainIndex .section .titulo {
  font-size: 3rem;
  font-family: "Passion One", cursive;
  border-top: 4px solid #06cacb;
  color: rgb(169, 63, 63);
  text-shadow: -3px 0 rgb(203, 7, 6);
  border-radius: 10px;
  writing-mode: vertical-lr;
  text-orientation: upright;
  text-align: center;
  background-color: rgb(236, 207, 10);
  border-radius: 10px;
}
.mainIndex .section .section__slider {
  display: flex;
  overflow-x: auto;
  gap: 5px;
  overflow-y: hidden;
  background-color: rgba(0, 0, 0, 0.3215686275);
}
.mainIndex .section .section__slider::-webkit-scrollbar {
  -webkit-appearance: none;
}
.mainIndex .section .section__slider::-webkit-scrollbar-button:increment, .mainIndex .section .section__slider .section__slider::-webkit-scrollbar-button {
  display: inline;
}
.mainIndex .section .section__slider::-webkit-scrollbar:horizontal {
  height: 12px;
}
.mainIndex .section .section__slider::-webkit-scrollbar-thumb {
  --g-red: #d04b36;
  --g-orange: #e36511;
  --g-yellow: #ffba00;
  --g-green: #00b180;
  --g-blue: #147aab;
  --g-indigo: #675997;
  background: linear-gradient(var(--g-red) 0%, var(--g-red) 16.6666%, var(--g-orange) 16.6666%, var(--g-orange) 33.333%, var(--g-yellow) 33.333%, var(--g-yellow) 50%, var(--g-green) 50%, var(--g-green) 66.6666%, var(--g-blue) 66.6666%, var(--g-blue) 83.3333%, var(--g-indigo) 83.3333%, var(--g-indigo) 100%);
  border-radius: 20px;
  border: 2px solid rgb(203, 7, 6);
}
.mainIndex .section .section__slider::-webkit-scrollbar-track {
  border-radius: 10px;
}
.mainIndex .section .section__slider .section__tarjeta {
  min-width: 420px;
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
}
.mainIndex .section .section__slider .section__tarjeta:hover figure {
  -webkit-transform: perspective(600px) rotateY(180deg);
  transform: perspective(600px) rotateY(180deg);
  -webkit-box-shadow: 0px 0px 20px 1px #98e7b1;
  box-shadow: 0px 0px 20px 1px #98e7b1;
}
.mainIndex .section .section__slider .section__tarjeta__contenedor {
  height: 100%;
}
.mainIndex .section .section__slider .section__tarjeta__contenedor a {
  display: inline-block;
  height: 100%;
}
.mainIndex .section .section__slider .section__tarjeta__contenedor a #btnControl {
  display: none;
}
.mainIndex .section .section__slider .section__tarjeta__contenedor a figure {
  margin: 0px;
  position: relative;
  transition: all ease 0.5s;
  transform-style: preserve-3d;
  transform: perspective(700px) rotateY(0deg);
  border: 23px solid #4a325a;
}
.mainIndex .section .section__slider .section__tarjeta__contenedor a figure .frontal {
  display: block;
  width: 100%;
  height: 100%;
}
.mainIndex .section .section__slider .section__tarjeta__contenedor a figure .trasera {
  position: absolute;
  top: 0px;
  padding: 20px;
  color: #98e7b1;
  transform: perspective(500px) rotateY(180deg);
  backface-visibility: hidden;
  overflow: auto;
  display: flex;
  flex-direction: column;
  background: linear-gradient(180deg, rgba(203, 7, 6, 0.4296285164) 7%, rgba(236, 207, 10, 0.4688442027) 63%);
  width: 100%;
  height: 100%;
  border-radius: 1px;
  transition: all ease 0.5s;
}
.mainIndex .section .section__slider .section__tarjeta__contenedor a figure .trasera div {
  margin-top: auto;
}
.mainIndex .section .section__slider .section__tarjeta__contenedor a figure .trasera div p, .mainIndex .section .section__slider .section__tarjeta__contenedor a figure .trasera div h4 {
  font-family: Roboto;
  text-shadow: 1px 0px 6px black;
}
.mainIndex .section .section__slider .section__tarjeta__contenedor:hover figure img {
  filter: blur(2px);
}
.mainIndex .sectionDos {
  box-shadow: 0 0 40px -30px #000;
}

.sectionUno {
  margin-top: 20px;
}

@media (max-width: 1000px) {
  .mainIndex .section {
    width: 100%;
    align-self: flex-start;
    margin-top: 2px;
  }
  .mainIndex .section .titulo {
    font-size: 1.5rem;
  }
  .mainIndex .section .section__slider {
    gap: 2px;
  }
  .mainIndex .section .section__slider .section__tarjeta {
    min-width: 350px;
  }
  .mainIndex .section .section__slider .section__tarjeta__contenedor a #btnControl:checked + label > img figure {
    -webkit-transform: perspective(600px) rotateY(180deg);
    transform: perspective(600px) rotateY(180deg);
    -webkit-box-shadow: 0px 0px 20px 1px #98e7b1;
    box-shadow: 0px 0px 20px 1px #98e7b1;
  }
  .mainIndex .section .section__slider .section__tarjeta__contenedor a figure {
    border: 10px solid #4a325a;
  }
}
.mainRevista {
  width: 100vw;
}

/*----------------------- PAG: CONTACTO ----------------------*/
/*---- Main ----*/
.mainContacto {
  display: flex;
  flex-wrap: nowrap;
  justify-content: center;
}
.mainContacto .divPrincipal {
  width: 80vw;
  height: 84.2vh;
  display: grid;
  grid-template-columns: 1fr 1fr;
  /*---- Section ----*/
}
.mainContacto .divPrincipal section {
  padding: 20px;
  margin: 20px;
  border-radius: 8px;
  box-shadow: 0 0 40px -10px #000;
  display: flex;
  align-items: center;
}
.mainContacto .divPrincipal .section1 {
  background-color: rgba(152, 231, 177, 0.9490196078);
  justify-content: center;
  align-items: center;
}
.mainContacto .divPrincipal .section2 {
  background-color: rgba(77, 49, 86, 0.924);
  flex-direction: column;
  justify-content: space-around;
}
.mainContacto .divPrincipal .section2 div {
  display: flex;
}
.mainContacto .divPrincipal .section2 div img {
  width: 115px;
  height: 115px;
  box-shadow: 0 0 40px -10px #000;
  border-radius: 12px;
}
.mainContacto .divPrincipal .section2 div p {
  align-self: center;
  color: #e798ce;
  font-family: Roboto;
}

@media (max-width: 862px) {
  .mainContacto {
    overflow-y: scroll;
    overflow-x: hidden;
  }
  .mainContacto .divPrincipal {
    grid-template-columns: 1fr;
    width: 100vw;
  }
  .mainContacto .divPrincipal .section1, .mainContacto .divPrincipal .section2 {
    margin: 4px;
  }
}
/*----------------------- PAG: KITNATURA ------------------*/
.mainKitNatura {
  display: flex;
  justify-content: center;
  width: 95vw;
  height: 100%;
}
.mainKitNatura__section {
  display: grid;
  grid-template-columns: 2fr 2fr 2fr;
  gap: 2px;
  grid-auto-rows: 300px;
  grid-auto-flow: row;
  margin-top: 20px;
}
.mainKitNatura__article {
  width: 300px;
  box-shadow: 0 0 40px -10px #000;
}
.mainKitNatura__article figure {
  display: flex;
  flex-direction: column;
  position: relative;
  height: 100%;
}
.mainKitNatura__article figure img {
  border-bottom: 1px solid #4a325a;
  border-radius: 10px;
}
.mainKitNatura__article figure figcaption {
  position: absolute;
  display: flex;
  flex-direction: column;
  justify-content: end;
  transition: all 0.3s;
  height: 100%;
  border-radius: 10px;
}
.mainKitNatura__article figure figcaption:hover {
  background: linear-gradient(180deg, rgb(74, 50, 90) 0%, rgba(253, 187, 45, 0) 100%);
  visibility: visible;
}
.mainKitNatura__article figure figcaption:hover h2 {
  visibility: visible;
}
.mainKitNatura__article figure figcaption:hover p {
  visibility: visible;
}
.mainKitNatura__article figure figcaption:hover button {
  visibility: visible;
}
.mainKitNatura__article figure figcaption h2 {
  visibility: hidden;
  font-family: Roboto;
  color: #eccf0a;
  text-shadow: -1px -1px 1px rgb(203, 7, 6);
  margin-left: 3px;
}
.mainKitNatura__article figure figcaption p {
  visibility: hidden;
  font-family: Roboto;
  text-shadow: -1px -1px 1px rgb(203, 7, 6);
  margin-left: 3px;
}
.mainKitNatura__article figure figcaption button {
  visibility: hidden;
}
.mainKitNatura__article figure:hover img {
  filter: blur(2px);
}

@media (max-width: 1000px) {
  .mainKitNatura {
    height: auto;
  }
  .mainKitNatura__section {
    grid-template-columns: 350px;
    gap: 2px;
    width: 100%;
    height: 100%;
  }
  .mainKitNatura__article figure {
    flex-direction: row;
    position: static;
    width: 350px;
  }
  .mainKitNatura__article figure img {
    width: 250px;
  }
  .mainKitNatura__article figure:hover img {
    filter: none;
  }
  .mainKitNatura__article figure figcaption button {
    background: #4a325a;
    color: #eccf0a;
  }
  .mainKitNatura__article figure figcaption {
    position: static;
    width: 150px;
    background: linear-gradient(180deg, rgb(74, 50, 90) 0%, rgba(253, 187, 45, 0) 100%);
  }
  .mainKitNatura__article figure figcaption p {
    visibility: visible;
    font-size: 14px;
  }
  .mainKitNatura__article figure figcaption h2 {
    visibility: visible;
    font-size: 15px;
  }
  .mainKitNatura__article figure figcaption button {
    visibility: visible;
    background-color: #4a325a;
    color: #eccf0a;
  }
}
/*-------------------- PAG: NATURA & TIPS -----------------*/
/*---- Main ----*/
.mainNaturaTips {
  display: flex;
  justify-content: center;
}
.mainNaturaTips .divPrincipal {
  width: 80vw;
  height: 83.4vh;
  display: grid;
  grid-template-columns: 2fr 1fr;
  /*---- Section ----*/
}
.mainNaturaTips .divPrincipal section {
  padding: 20px;
  background-color: rgba(152, 231, 177, 0.9490196078);
  margin: 20px;
  margin-right: 0px;
  text-align: left;
  box-shadow: 0 0 40px -10px #000;
  border-radius: 12px;
}
.mainNaturaTips .divPrincipal section p, .mainNaturaTips .divPrincipal section h2, .mainNaturaTips .divPrincipal section h3 {
  font-family: Roboto;
  text-shadow: -1px 0px 1px #eccf0a;
  color: #4a325a;
}
.mainNaturaTips .divPrincipal section h3 {
  text-align: center;
  color: #eccf0a;
}
.mainNaturaTips .divPrincipal section .videonatura {
  width: 100%;
  height: 100%;
}
.mainNaturaTips .divPrincipal .section2 {
  display: flex;
  flex-direction: column;
  overflow-y: scroll;
  background-color: rgba(77, 49, 86, 0.924);
  align-items: center;
  padding: 1px;
  /*scrollbar*/
}
.mainNaturaTips .divPrincipal .section2::-webkit-scrollbar {
  -webkit-appearance: none;
}
.mainNaturaTips .divPrincipal .section2::-webkit-scrollbar-button:increment, .mainNaturaTips .divPrincipal .section2 .section__slider::-webkit-scrollbar-button {
  display: inline;
}
.mainNaturaTips .divPrincipal .section2::-webkit-scrollbar:horizontal {
  height: 12px;
}
.mainNaturaTips .divPrincipal .section2::-webkit-scrollbar-thumb {
  --g-red: #d04b36;
  --g-orange: #e36511;
  --g-yellow: #ffba00;
  --g-green: #00b180;
  --g-blue: #147aab;
  --g-indigo: #675997;
  background: linear-gradient(90deg, var(--g-red) 0%, var(--g-red) 16.6666%, var(--g-orange) 16.6666%, var(--g-orange) 33.333%, var(--g-yellow) 33.333%, var(--g-yellow) 50%, var(--g-green) 50%, var(--g-green) 66.6666%, var(--g-blue) 66.6666%, var(--g-blue) 83.3333%, var(--g-indigo) 83.3333%, var(--g-indigo) 100%);
  border-radius: 20px;
  border: 2px solid rgb(203, 7, 6);
}
.mainNaturaTips .divPrincipal .section2::-webkit-scrollbar-track {
  border-radius: 10px;
}
.mainNaturaTips .divPrincipal .section2 .video {
  display: flex;
  flex-direction: column;
}
.mainNaturaTips .divPrincipal .section2 .video iframe:hover {
  box-shadow: 0px 0px 4px 1px #98e7b1;
  overflow: hidden;
}

@media (max-width: 830px) {
  .mainNaturaTips {
    overflow-y: scroll;
  }
  .mainNaturaTips .divPrincipal {
    grid-template-columns: 1fr;
  }
  .mainNaturaTips .divPrincipal .section2 {
    overflow-y: visible;
  }
}

/*# sourceMappingURL=styles.cs.map */
