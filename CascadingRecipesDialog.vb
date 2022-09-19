Imports System.IO
Imports System.IO.Ports

Public Class CascadingRecipesDialog
    Dim addRecipeDialog1 As New OpenFileDialog()
    Dim st_RecipePath As String = "C:\OTT_PLUS\Recipes\" 'Recipe Path without filename    
    Dim st_RecipeFileName As String = "none_entered" 'Recipe filename for display
    Dim st_RecipeString As String = ""
    Dim st_RecipePathFileName As String
    
    Dim st_CascadeRecipePath As String = "C:\OTT_PLUS\Cascade Recipes\" 'Recipe Path without filename    
    Dim st_CascadeRecipeFileName As String = "none_entered" 'Recipe filename for display
    Dim st_CascadeRecipeString As String = ""
    Dim st_CascadeRecipePathFileName As String
    

    Private Sub AddRecipeBtn_Click(sender As Object, e As EventArgs) Handles AddRecipeBtn.Click
        ' Displays an addRecipeDialog1 so the user can add a Recipe to the Cascaded Recipe.
       
        'The Dialog window contents
        addRecipeDialog1.InitialDirectory = st_RecipePath 'hard coded st_RecipePath as initialized at startup above
        addRecipeDialog1.Filter = "Recipe|*.rcp"
        addRecipeDialog1.Title = "Add a Recipe to the Cascade Recipe"

        ' Show the Dialog.
        ' If the user clicked OK in the dialog and 
        ' a .rcp file was selected, add it to the list.
        If addRecipeDialog1.ShowDialog() = DialogResult.OK Then
            st_RecipeFileName = addRecipeDialog1.SafeFileName
            st_RecipeFileName = st_RecipeFileName.Substring(0, st_RecipeFileName.Length - 4) 'strip off '.rcp'            
            'Add the recipe file name to our list
            CascadeRecipeListBox.Items.Add(st_RecipeFileName)
        End If           
                
    End Sub

    Private Sub RemoveRecipeBtn_Click(sender As Object, e As EventArgs) Handles RemoveRecipeBtn.Click
        if CascadeRecipeListBox.SelectedIndex >= 0 then
            CascadeRecipeListBox.Items.RemoveAt(CascadeRecipeListBox.SelectedIndex)
        End if
    End Sub

    Private Sub ConfirmRecipeBtn_Click(sender As Object, e As EventArgs) Handles ConfirmRecipeBtn.Click        
        Me.Close        
    End Sub

    Private Sub SaveRecipeBtn1_Click(sender As Object, e As EventArgs) Handles SaveRecipeBtn.Click
        st_CascadeRecipeFileName = InputBox("No extension", "Enter Cascade Recipe Name", st_CascadeRecipeFileName)
        'ActiveRecipeName.Text = st_RecipeFileName
               
        st_CascadeRecipePathFileName = st_CascadeRecipePath + st_CascadeRecipeFileName + ".crcp"
        'build the Recipe from current data
        'Make sure there are at least two recipes for a cascade recipe
        If CascadeRecipeListBox.Items.Count < 2 Then 
            MsgBox("You need at least TWO recipes to save a cascade recipe.")
        Else 
            'Need to reset the string or could have added to a previous recipe string
            st_CascadeRecipeString = ""
            For Each recipe In CascadeRecipeListBox.Items
            st_CascadeRecipeString += recipe & vbcrlf 
            Next

            Using RecipeOut As New StreamWriter(st_CascadeRecipePathFileName)
                RecipeOut.Write(st_CascadeRecipeString)
                RecipeOut.Close()
            End Using
        End If
        

    End Sub
End Class