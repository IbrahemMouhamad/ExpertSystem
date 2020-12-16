(deftemplate computer_problem
	(slot name (type STRING))
	(slot value (type INTEGER))
        (slot cf (type FLOAT) (default 1.0)(range -1.0 +1.0))	)

(defrule Rule1
	(computer_problem (name "computerworking")(value 0) )
	(computer_problem (name "beepssound") (value 1) ) 
=>
	(Finish1) )

(defrule Rule2
	(computer_problem (name "computerworking")(value 0) )
	(computer_problem (name "beepssound") (value 0) )
	(computer_problem (name "isdmessage") (value 1) )
	(computer_problem (name "cd-romdisk") (value 1) )
=>
	(Finish2) )

(defrule Rule3
	(computer_problem (name "computerworking")(value 0) )
	(computer_problem (name "beepssound") (value 0) )
	(computer_problem (name "isdmessage") (value 1) )
	(computer_problem (name "cd-romdisk") (value 0) )
=>
	(Finish3)   )

(defrule Rule4
	(computer_problem (name "computerworking")(value 0) )
	(computer_problem (name "beepssound") (value 0) )
	(computer_problem (name "isdmessage") (value 0) )
=>
	(Finish4)  )

(defrule Rule5
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "mouseproblem") (value 1) )
	(computer_problem (name "mcabel") (value 1) )
=>
	(Finish5) )

(defrule Rule6
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "mouseproblem") (value 1) )
	(computer_problem (name "mcabel") (value 0) )
=>
	(Finish6))

(defrule Rule7
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "keyboardproblem") (value 1) )
	(computer_problem (name "kcabel") (value 1) )
=>
	(Finish7) )

(defrule Rule8
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "keyboardproblem") (value 1) )
	(computer_problem (name "kcabel") (value 0) )
=>
	(Finish8) )

(defrule Rule9
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "printerproblem") (value 1) )
	(computer_problem (name "printerprint") (value 0) )
=>
	(Finish9))

(defrule Rule10
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "printerproblem") (value 1) )
	(computer_problem (name "printerprint") (value 1) )
	(computer_problem (name "printclear") (value 0) )
=>
	(Finish10))

(defrule Rule11
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "printerproblem") (value 1) )
	(computer_problem (name "printerprint") (value 1) )
	(computer_problem (name "printclear") (value 1) )
=>
	(Finish11))
 
(defrule Rule12
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "soundproblem") (value 1) )
	(computer_problem (name "soundappear") (value 0) )
	(computer_problem (name "speakerconnected") (value 1) )
	(computer_problem (name "muteall") (value 0) )
=>
	(Finish12))

(defrule Rule13
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "soundproblem") (value 1) )
	(computer_problem (name "soundappear") (value 0) )
	(computer_problem (name "speakerconnected") (value 1) )
	(computer_problem (name "muteall") (value 1) )
=>
	(Finish13) )

(defrule Rule14
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "soundproblem") (value 1) )
	(computer_problem (name "soundappear") (value 0) )
	(computer_problem (name "speakerconnected") (value 0) )
=>
	(Finish14) )

(defrule Rule15
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "soundproblem") (value 1) )
	(computer_problem (name "soundappear") (value 1) )
	(computer_problem (name "soundclear") (value 0) )
=>
	(Finish15))

(defrule Rule16
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "soundproblem") (value 1) )
	(computer_problem (name "soundappear") (value 1) )
	(computer_problem (name "soundclear") (value 1) )
=>
	(Finish16))

(defrule Rule17
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "screenproblem") (value 1) )
	(computer_problem (name "screenwork") (value 0) )
	(computer_problem (name "lampwork") (value 1) )
=>
	(Finish17))
	
(defrule Rule18
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "screenproblem") (value 1) )
	(computer_problem (name "screenwork") (value 0) )
	(computer_problem (name "lampwork") (value 0) )
=>
	(Finish18))	
	
(defrule Rule19
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "screenproblem") (value 1) )
	(computer_problem (name "screenwork") (value 1) )
	(computer_problem (name "suitablecolor") (value 0) )
=>
	(Finish19))	

(defrule Rule20
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "screenproblem") (value 1) )
	(computer_problem (name "screenwork") (value 1) )
	(computer_problem (name "suitablecolor") (value 1) )
	(computer_problem (name "basiccolor") (value 1) )
	
=>
	(Finish20))	
	
(defrule Rule21
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "screenproblem") (value 1) )
	(computer_problem (name "screenwork") (value 1) )
	(computer_problem (name "basiccolor") (value 0) )
=>
	(Finish21))	

(defrule Rule22
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "modemproblem") (value 1) )
	(computer_problem (name "ringup") (value 0) )
	(computer_problem (name "phoneline") (value 0) )
=>
	(Finish22))	

(defrule Rule23
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "modemproblem") (value 1) )
	(computer_problem (name "ringup") (value 0) )
	(computer_problem (name "phoneline") (value 1) )
=>
	(Finish23))	

(defrule Rule24
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "modemproblem") (value 1) )
	(computer_problem (name "ringup") (value 1) )
	(computer_problem (name "wrongnumber") (value 1) )

=>
	(Finish24))	

(defrule Rule25
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "modemproblem") (value 1) )
	(computer_problem (name "ringup") (value 1) )
	(computer_problem (name "wrongnumber") (value 0) )
	(computer_problem (name "dialsetting") (value 1) )

=>
	(Finish25))	

(defrule Rule26
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "modemproblem") (value 1) )
	(computer_problem (name "ringup") (value 1) )
	(computer_problem (name "wrongnumber") (value 0) )
	(computer_problem (name "dialsetting") (value 0) )

=>
	(Finish26))		
	
(defrule Rule27
	(computer_problem (name "computerworking")(value 1) )
	(computer_problem (name "modemproblem") (value 0) )
=>
	(Finish27))	