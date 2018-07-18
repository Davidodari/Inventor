Public Class loginPage

    'Array for Users And Passwords
   Dim multipleLogin() As String = {"David", "Edgar","Maureen","root"}
   Dim multiplePassword() As String = {"Abcd1234","Abcd1234","Abcd1234", "toor"}

   Private Sub loginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      ' loads data into the 'BATTERIESDataSet.Customer_Information' table. You can move, or remove it, as needed.
      Me.Customer_InformationTableAdapter.Fill(Me.BATTERIESDataSet.Customer_Information)
      ' loads data into the 'BATTERIESDataSet.Customer_Order' table. You can move, or remove it, as needed.
      Me.Customer_OrderTableAdapter.Fill(Me.BATTERIESDataSet.Customer_Order)
      ' loads data into the 'BATTERIESDataSet.Restock' table. You can move, or remove it, as needed.
      Me.RestockTableAdapter.Fill(Me.BATTERIESDataSet.Restock)
      ' loads data into the 'BATTERIESDataSet.Inventory' table. You can move, or remove it, as needed.
      Me.InventoryTableAdapter.Fill(Me.BATTERIESDataSet.Inventory)
      ' loads data into the 'BATTERIESDataSet.Product_Details' table. You can move, or remove it, as needed.
      Me.Product_DetailsTableAdapter.Fill(Me.BATTERIESDataSet.Product_Details)
      
   End Sub

   'LOGIN GUI
   Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
      'if statement checks condition of entered text if it matches the ones in array user proceeds
      If usernameTextBox.Text = multipleLogin(0) And passwordTextBox.Text = multiplePassword(0) Then
         loginGroupBox.Visible = False
         tabControls.Visible = True

      ElseIf usernameTextBox.Text = multipleLogin(1) And passwordTextBox.Text = multiplePassword(1) Then
         loginGroupBox.Visible = False
         tabControls.Visible = True
      ElseIf usernameTextBox.Text = multipleLogin(2) And passwordTextBox.Text = multiplePassword(2) Then
         loginGroupBox.Visible = False
         tabControls.Visible = True
      ElseIf usernameTextBox.Text = multipleLogin(3) And passwordTextBox.Text = multiplePassword(3) Then
         loginGroupBox.Visible = False
         tabControls.Visible = True
      Else
         MessageBox.Show("Incorrect password. Try again.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If
   End Sub
   'Application Exit
   Private Sub cnclButton_Click(sender As Object, e As EventArgs) Handles cnclButton.Click
      Application.Exit()
   End Sub
    'Clear Textbox fields
   Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
      usernameTextBox.Clear()
      passwordTextBox.Clear()
   End Sub
   'end of login gui


   Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton0.Click, exitButton1.Click, exitButton2.Click, exitButton3.Click, exitButton4.Click
      Dim exitprompt = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
      If exitprompt = Windows.Forms.DialogResult.Yes Then
         Application.Exit()
      End If
   End Sub

   'start of inventory system gui

   'product details
   Private Sub newButton0_Click(sender As Object, e As EventArgs) Handles newButton0.Click
      ProductDetailsBindingSource.AddNew()
   End Sub

   Private Sub storeButton0_Click(sender As Object, e As EventArgs) Handles storeButton0.Click
      Me.Validate()
      Me.ProductDetailsBindingSource.EndEdit()
      Me.Product_DetailsTableAdapter.Update(Me.BATTERIESDataSet)
   End Sub

   Private Sub nextButton0_Click(sender As Object, e As EventArgs) Handles nextButton0.Click
      ProductDetailsBindingSource.MoveNext()
   End Sub

   Private Sub previousButton0_Click(sender As Object, e As EventArgs) Handles previousButton0.Click
      ProductDetailsBindingSource.MovePrevious()
   End Sub

   Private Sub deleteButton0_Click(sender As Object, e As EventArgs) Handles deleteButton0.Click
      ProductDetailsBindingSource.RemoveCurrent()
   End Sub

   'inventory
   Private Sub newButton1_Click(sender As Object, e As EventArgs) Handles newButton1.Click
      InventoryBindingSource.AddNew()
   End Sub

   Private Sub storeButton1_Click(sender As Object, e As EventArgs) Handles storeButton1.Click
      Me.Validate()
      Me.InventoryBindingSource.EndEdit()
      Me.InventoryTableAdapter.Update(Me.BATTERIESDataSet)
   End Sub

   Private Sub nextButton1_Click(sender As Object, e As EventArgs) Handles nextButton1.Click
      InventoryBindingSource.MoveNext()
   End Sub

   Private Sub previousButton1_Click(sender As Object, e As EventArgs) Handles previousButton1.Click
      InventoryBindingSource.MovePrevious()
   End Sub

   Private Sub deleteButton1_Click(sender As Object, e As EventArgs) Handles deleteButton1.Click
      InventoryBindingSource.RemoveCurrent()
   End Sub

   'restock
   Private Sub newButton2_Click(sender As Object, e As EventArgs) Handles newButton2.Click
      RestockBindingSource.AddNew()
   End Sub

   Private Sub storeButton2_Click(sender As Object, e As EventArgs) Handles storeButton2.Click
      Me.Validate()
      Me.RestockBindingSource.EndEdit()
      Me.RestockTableAdapter.Update(Me.BATTERIESDataSet)
   End Sub

   Private Sub nextButton2_Click(sender As Object, e As EventArgs) Handles nextButton2.Click
      RestockBindingSource.MoveNext()
   End Sub

   Private Sub previousButton2_Click(sender As Object, e As EventArgs) Handles previousButton2.Click
      RestockBindingSource.MovePrevious()
   End Sub

   Private Sub deleteButton2_Click(sender As Object, e As EventArgs) Handles deleteButton2.Click
      RestockBindingSource.RemoveCurrent()
   End Sub

   'customer order
   Private Sub newButton3_Click(sender As Object, e As EventArgs) Handles newButton3.Click
      CustomerOrderBindingSource.AddNew()
   End Sub

   Private Sub storeButton3_Click(sender As Object, e As EventArgs) Handles storeButton3.Click
      Me.Validate()
      Me.CustomerOrderBindingSource.EndEdit()
      Me.Customer_OrderTableAdapter.Update(Me.BATTERIESDataSet)
   End Sub

   Private Sub nextButton3_Click(sender As Object, e As EventArgs) Handles nextButton3.Click
      CustomerOrderBindingSource.MoveNext()
   End Sub

   Private Sub previousButton3_Click(sender As Object, e As EventArgs) Handles previousButton3.Click
      CustomerOrderBindingSource.MovePrevious()
   End Sub

   Private Sub deleteButton3_Click(sender As Object, e As EventArgs) Handles deleteButton3.Click
      CustomerOrderBindingSource.RemoveCurrent()
   End Sub

   'customer information
   Private Sub newButton4_Click(sender As Object, e As EventArgs) Handles newButton4.Click
      CustomerInformationBindingSource.AddNew()
   End Sub

   Private Sub storeButton4_Click(sender As Object, e As EventArgs) Handles storeButton4.Click
      Me.Validate()
      Me.CustomerInformationBindingSource.EndEdit()
      Me.Customer_InformationTableAdapter.Update(Me.BATTERIESDataSet)
   End Sub

   Private Sub nextButton4_Click(sender As Object, e As EventArgs) Handles nextButton4.Click
      CustomerInformationBindingSource.MoveNext()
   End Sub

   Private Sub previousButton4_Click(sender As Object, e As EventArgs) Handles previousButton4.Click
      CustomerInformationBindingSource.MovePrevious()
   End Sub

   Private Sub deleteButton4_Click(sender As Object, e As EventArgs) Handles deleteButton4.Click
      CustomerInformationBindingSource.RemoveCurrent()
   End Sub

 









    'end of inventory system gui


End Class
