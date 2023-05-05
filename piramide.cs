
namespace Piramide{
    public static class Piramide {

        public static int Piani( int mattoni )
        {
            if(mattoni<=0){
                return 0;
            }
            int risultato=0;
            int counterFloors=0;
            int counterBlocks=1;

            for(counterFloors=0;mattoni>0;counterFloors++){
                risultato = counterBlocks*counterBlocks;
                mattoni-=risultato;
                counterBlocks+=2;
            }

            if(mattoni<0){
                counterFloors--;
            }
            
            return counterFloors;
        }
        public static int Rimanenti( int mattoni )
        {
            int piani=Piani(mattoni);
            int restoMattoni=mattoni;
            int num=1;
            
            for(int i=0;i<piani;i++){
                restoMattoni-=num*num;
                num+=2;
            }
            return restoMattoni;
        }

    }
}