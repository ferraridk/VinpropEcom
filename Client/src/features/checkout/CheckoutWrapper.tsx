import { Elements } from "@stripe/react-stripe-js";
import CheckoutPage from "./CheckoutPage";
import { loadStripe } from "@stripe/stripe-js";
import { useState, useEffect } from "react";
import agent from "../../app/api/agent";
import LoadingComponent from "../../app/layout/LoadingComponent";
import { useAppDispatch } from "../../app/store/configureStore";
import { setBasket } from "../basket/basketSlice";

const stripePromise = loadStripe(
  "pk_test_51ONLLSKsFsxQ5wuZkTURhK4O8SMGVvMnEkRnRkN1nhGq4M2PTPxcMTs8M3bXM9YYDG5vYROX7Zv3g8ACckaDJbIS00QnZXife3"
);

export default function CheckoutWrapper() {

  const dispatch = useAppDispatch();
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        agent.Payments.createPaymentIntent()
            .then(response => dispatch(setBasket(response)))
            .catch(error => console.log(error))
            .finally(() => setLoading(false))
    }, [dispatch]);

    if (loading) return <LoadingComponent message='Indlæser checkout' />


  return (
    <Elements stripe={stripePromise}>
      <CheckoutPage />
    </Elements>
  );
}
