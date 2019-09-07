'
' Created by SharpDevelop.
' User: E19
' Date: 06/09/2019
' Time: 07:31 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Dim nombreArchivo As String = "Sin nombre.txt"
	Dim textoModificado As Boolean = False
	
	Sub LimpiarTxt()
		txtEditor.Text = ""
		Me.Text = nombreArchivo
		textoModificado = False
	End Sub
	
	Sub MnNuevoClick(sender As Object, e As EventArgs)
		
		Dim resultado As MsgBoxResult
		
		If textoModificado Then
			resultado = MsgBox("¿Deseas guardar los cambios de "+nombreArchivo+"?",MsgBoxStyle.YesNoCancel, "Bloc de notas")
			Select Case resultado
				Case vbYes 'MsgBoxResult.Yes
					'Guardar cambios y limpiar
					LimpiarTxt
				Case vbNo
					LimpiarTxt
			End Select
		End If
		
	End Sub
	
	Sub MnSalirClick(sender As Object, e As EventArgs)
		Me.Close
	End Sub
	
	Sub TxtEditorTextChanged(sender As Object, e As EventArgs)
		If Not textoModificado Then
			textoModificado = True
			Me.Text = "*" + nombreArchivo
		End If		
	End Sub
	
	Sub MainFormFormClosing(sender As Object, e As FormClosingEventArgs)
		Dim resultado As MsgBoxResult
		If textoModificado Then
			resultado = MsgBox("¿Deseas guardar los cambios de "+nombreArchivo+"?",MsgBoxStyle.YesNoCancel, "Bloc de notas")
			Select Case resultado
				Case vbYes 'MsgBoxResult.Yes
					
				Case vbCancel
					e.Cancel = True
			End Select
		End If
	End Sub
	
End Class
