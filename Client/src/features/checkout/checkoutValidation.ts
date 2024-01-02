import * as yup from "yup";

export const validationSchema = [
  yup.object({
    fullName: yup.string().required("Fulde navn er påkrævet"),
    address1: yup.string().required("Adresse er påkrævet"),
    address2: yup.string(),
    city: yup.string().required("By er påkrævet"),
    region: yup.string(),
    zip: yup.string().required("Postnummer er påkrævet"),
    country: yup.string().required("Land er påkrævet"),
  }),
  yup.object(),
  yup.object({
    nameOnCard: yup.string().required(),
  }),
];
