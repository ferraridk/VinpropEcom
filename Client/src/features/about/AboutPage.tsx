import { Box, Typography, CssBaseline } from "@mui/material";

export default function AboutPage() {
  return (
    <>
      <CssBaseline />
      <Box
        sx={{
          backgroundImage: 'url("/images/omos.png")',
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
            maxWidth: "600px",
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
            Om Vinproppen
          </Typography>
          <Typography
            variant="h6"
            sx={{
              color: "white",
              mb: 4,
            }}
          >
            Hos Vinproppen er vi passionerede omkring kvalitetsvine. Vi stræber
            efter at bringe dig et håndplukket udvalg af verdens bedste vine,
            lige til din dør.
          </Typography>
          <Typography
            sx={{
              color: "white",
              mb: 4,
            }}
          >
            Vi har denne webshop, da vi alle har en stor passion for vine, og det der er med til at samle os.
            Skulle du have spørgsmål, kan du altid kontakte os.
          </Typography>
          <Typography
            variant="h6"
            sx={{
              color: "white",
              mb: 2,
            }}
          >
            CVR: 37329304
          </Typography>
        </Box>
      </Box>
    </>
  );
}
