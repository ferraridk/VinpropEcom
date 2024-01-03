import { Box, Typography, Pagination } from "@mui/material";
import { MetaData } from "../models/pagination";

interface Props {
  metaData: MetaData;
  onPageChange: (page: number) => void;
}

export default function AppPagination({ metaData, onPageChange }: Props) {
  const { currentPage, totalCount, totalPages, pageSize } = metaData;
  return (
    <Box
      sx={{
        display: "flex",
        justifyContent: "space-between",
        alignItems: "center",
        backgroundColor: "rgba(168, 142, 105, 1.9)",
        borderRadius: "20px",
        padding: "10px",
        boxShadow: "0px 0px 10px rgba(0, 0, 0, 0.1)", 
      }}
    >
      <Typography sx={{ color: "#9c27b0" }}>
        Viser {(currentPage - 1) * pageSize + 1}-
        {currentPage * pageSize > totalCount
          ? totalCount
          : currentPage * pageSize}{" "}
        ud af {totalCount} produkter
      </Typography>
      <Pagination
        color="secondary"
        size="large"
        count={totalPages}
        page={currentPage}
        onChange={(_e, page) => onPageChange(page)}
      />
    </Box>
  );
}
