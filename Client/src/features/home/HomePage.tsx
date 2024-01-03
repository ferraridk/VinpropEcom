import { Box, Typography } from "@mui/material";

export default function HomePage() {
  return (
    <Box
      style={{
        backgroundImage: 'url("/images/Vinmark1.png")',
        backgroundSize: "cover",
        backgroundPosition: "center",
        position: "fixed", // Gør Box positioneret absolut
        top: 0,
        left: 0,
        width: "100vw",
        height: "100vh",
        display: "flex",
        flexDirection: "column",
        justifyContent: "flex-start",
        alignItems: "center",
        paddingTop: "10vh",
      }}
    >
      <Box
        style={{
          backgroundColor: "rgba(0, 0, 0, 0.3)", // Næsten gennemsigtig sort
          padding: "20px",
          borderRadius: "20px", // Tilføjer let afrundede hjørner
        }}
      >
        <Typography
          variant="h1"
          style={{
            color: "white",
            textShadow: "2px 2px 4px rgba(210, 95, 95, 0.5)",
          }}
        >
          Velkommen til Vinproppen
        </Typography>
      </Box>
    </Box>
  );
}
