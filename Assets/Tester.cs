using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour {

    private Player player = new Player();
    
    
    void Start() {

        player.Power = 150;
        
        Debug.Log(player.GetPower());

    }


    public class Player {
        private int power;

        private int shield;
        public int Shield {
            get {
                return shield;
            }

            set {
                shield = value;
            }

        }





        public int Power {
            get {
                return power;
            }

            set {
                power = value;
            }
        }


        public int GetPower() {
            return this.power;
        }




    }



}

