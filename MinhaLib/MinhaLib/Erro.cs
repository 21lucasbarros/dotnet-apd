﻿namespace MinhaLib
{
    class Erro
    {
        private static bool erro;
        private static String mens;

        public static void setErro(bool _erro) { erro = _erro; }
        public static void setErro(String _mens) { erro = true; mens = _mens; }
        public static bool getErro() { return erro; }
        public static String getMens() { return mens; }
    }
}