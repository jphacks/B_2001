#include <Dps310.h>

// Dps310 Opject
Dps310 Dps310PressureSensor = Dps310();

void setup()
{
  // serial begin
  Serial.begin(9600);
  while (!Serial);

  // wire begin
  Dps310PressureSensor.begin(Wire);
}



void loop()
{
  //float temperature;
  float pressure;
  uint8_t oversampling = 7;
  int16_t ret;

  /*// get temp
  ret = Dps310PressureSensor.measureTempOnce(temperature, oversampling);
  if (ret != 0)
  {

  }
  else
  {
    Serial.println(temperature);
  }*/

  // get atm
  ret = Dps310PressureSensor.measurePressureOnce(pressure, oversampling);
  if (ret != 0)
  {

  }
  else
  {
    // hPa
    Serial.println(pressure/100);
  }

  delay(1000);
}
