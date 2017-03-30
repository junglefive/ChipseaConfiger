/*-------------------------------------------
@Name    : F_Sys_Init
@Function: System Initiate
@Input   : 
@Output  :
@Temp    :  
@Other   :
@log:
--------------------------------------------*/
F_Sys_Init:
    




    return
/*-------------------------------------------
@Name    : F_DELAY_1MS
@Function: F_DELAY_1MS OF 1M CPUCLKS
@Input   : NONE
@Output  : INTE.GIE = 1
@Temp    : WORK, INTE
@Other   : IF(CLK =  1M, DELAY = 1.000MS)
@log:	 : (3+4*249-1+2) = 1000 CPUCLKS
--------------------------------------------*/
F_DELAY_1MS:
	BCF    INTE, GIE
	MOVLW  0X0F				   /*COUNT = 249*/		
	NOP
	NOP
	NOP
	INCFSZ WORK, W
	GOTO   $-3
	BSF    INTE, GIE
	RETURN
/*-------------------------------------------
@Name    : 
@Function: 
@Input   : 
@Output  :
@Temp    :  
@Other   :
@log     :
--------------------------------------------*/
movff MACRO f1, f2
    movfw f1
    movwf f2
    endm
/*-------------------------------------------
@Name    : movlf
@Function: 
@Input   : 
@Output  :
@Temp    :  
@Other   :
@log     :
--------------------------------------------*/
movlf MACRO f1, f2
    movlw f1
    movwf f2
    endm
/*------------------------------------------*/