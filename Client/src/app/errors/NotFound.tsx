import { Link } from "react-router-dom";
import { Button, Container, Divider, Paper, Typography } from "@mui/material";

export default function NotFound() {
  return (
    <Container component={Paper} style={{ height: 400 }}>
      <Typography gutterBottom variant={"h3"}>
        Oops - Vi fandt ikke det du ledte efter!
      </Typography>
      <Divider />
      <Button component={Link} to="/catalog" fullWidth>
        Gå tilbage til kataloget
      </Button>
    </Container>
  );
}
