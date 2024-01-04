import { Navigate, Outlet, useLocation } from "react-router-dom";
import { useAppSelector } from "../store/configureStore";
import { toast } from "react-toastify";

interface Props {
  roles?: string[];
}

export default function RequireAuth({ roles }: Props) {
  const { user } = useAppSelector((state) => state.account);
  const location = useLocation();

  if (!user) {
    toast.error("Du har ikke tilladelse til dette!");
    return <Navigate to="/login" state={{ from: location }} />;
  }

  if (roles && !roles?.some((r) => user.roles?.includes(r))) {
    toast.error("Ikke autoriseret til dette område");
    return <Navigate to="/catalog" />;
  }

  return <Outlet />;
}
