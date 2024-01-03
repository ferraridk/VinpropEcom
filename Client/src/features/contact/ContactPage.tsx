import { Box, Typography, CssBaseline, Link } from "@mui/material";

export default function ContactPage() {
  return (
    <>
      <CssBaseline />
      <Box
        sx={{
          backgroundImage: 'url("/images/kontaktos.png")',
          backgroundSize: "cover",
          backgroundPosition: "center",
          backgroundRepeat: "no-repeat",
          position: "fixed",
          top: 0,
          left: 0,
          width: "100vw",
          height: "100vh",
          display: "flex",
          flexDirection: "column",
          alignItems: "center",
          justifyContent: "center",
          padding: "20px",
          boxSizing: "border-box",
        }}
      >
        <Box
          sx={{
            backgroundColor: "rgba(0, 0, 0, 0.7)",
            padding: "20px",
            borderRadius: "20px",
            textAlign: "center",
          }}
        >
          <Typography
            variant="h2"
            gutterBottom
            sx={{
              color: "white",
              textShadow: "2px 2px 4px rgba(0,0,0,0.5)",
            }}
          >
            Kontakt
          </Typography>
          <Typography sx={{ color: "white", mb: 4 }}>
            Vinproppen I/S
            <br />
            Kronprinsensgade 139
            <br />
            6700 Esbjerg
            <br />
            Email: Vinproppendk@gmail.com
          </Typography>
          <Typography variant="h6" sx={{ color: "white", mt: 4, mb: 2 }}>
            Følg os på sociale medier:
          </Typography>
          <Typography sx={{ color: "white", mb: 2 }}>
            Følg os på Facebook for at holde øje med events m.m.
          </Typography>
          <Link
            href="https://www.facebook.com/vinproppen"
            color="inherit"
            target="_blank"
            sx={{ color: "white", display: "block", mb: 4 }}
          >
            Facebook
          </Link>
          <Typography sx={{ color: "white", mb: 2 }}>
            Instagram for at se stemningsbilleder af vores udvalg.
          </Typography>
          <Link
            href="https://www.instagram.com/vinproppennet/"
            color="inherit"
            target="_blank"
            sx={{ color: "white", display: "block", mb: 4 }}
          >
            Instagram
          </Link>
        </Box>
      </Box>
    </>
  );
}
