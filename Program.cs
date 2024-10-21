

double[] temperatur={4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9};
	Console.WriteLine("Medelvärde: "+ Medel(temperatur));
    

double Medel(double[] v){
    double summa =0; 
    int antal = 0;
    for(int i=0; i<7; i++){
        summa += v[i];
        antal++;
    }
    return Math.Round(summa/antal, 2);
    
}

