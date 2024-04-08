Namespace dxWinFormsSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.lookUpPaperType = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.btnBuildReport = New DevExpress.XtraEditors.SimpleButton()
            Me.LabelWidthSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.LabelHeightSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.VerticalPitchSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.HorizontalPitchSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.BottomMarginSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.TopMarginSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.LeftMarginSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.RightMarginSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.lookUpLabelProduct = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.lookUpProductNumber = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.UnitComboBox = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForLabelWidth = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForLabelHeight = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForBottomMargin = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForVerticalPitch = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForTopMargin = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForLeftMargin = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForRightMargin = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForHorizontalPitch = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType(Me.lookUpPaperType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LabelWidthSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LabelHeightSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VerticalPitchSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HorizontalPitchSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BottomMarginSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TopMarginSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LeftMarginSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RightMarginSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lookUpLabelProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lookUpProductNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UnitComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForLabelWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForLabelHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForBottomMargin, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForVerticalPitch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForTopMargin, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForLeftMargin, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForRightMargin, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForHorizontalPitch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.Controls.Add(Me.lookUpPaperType)
            Me.dataLayoutControl1.Controls.Add(Me.btnBuildReport)
            Me.dataLayoutControl1.Controls.Add(Me.LabelWidthSpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.LabelHeightSpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.VerticalPitchSpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.HorizontalPitchSpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.BottomMarginSpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.TopMarginSpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.LeftMarginSpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.RightMarginSpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.lookUpLabelProduct)
            Me.dataLayoutControl1.Controls.Add(Me.lookUpProductNumber)
            Me.dataLayoutControl1.Controls.Add(Me.UnitComboBox)
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(648, 122, 450, 400)
            Me.dataLayoutControl1.Root = Me.layoutControlGroup1
            Me.dataLayoutControl1.Size = New System.Drawing.Size(433, 485)
            Me.dataLayoutControl1.TabIndex = 0
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' lookUpPaperType
            ' 
            Me.lookUpPaperType.Location = New System.Drawing.Point(104, 380)
            Me.lookUpPaperType.Name = "lookUpPaperType"
            Me.lookUpPaperType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpPaperType.Properties.View = Me.gridLookUpEdit1View
            Me.lookUpPaperType.Size = New System.Drawing.Size(305, 20)
            Me.lookUpPaperType.StyleController = Me.dataLayoutControl1
            Me.lookUpPaperType.TabIndex = 15
            ' 
            ' gridLookUpEdit1View
            ' 
            Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
            Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            ' 
            ' btnBuildReport
            ' 
            Me.btnBuildReport.Location = New System.Drawing.Point(12, 416)
            Me.btnBuildReport.Name = "btnBuildReport"
            Me.btnBuildReport.Size = New System.Drawing.Size(409, 57)
            Me.btnBuildReport.StyleController = Me.dataLayoutControl1
            Me.btnBuildReport.TabIndex = 13
            Me.btnBuildReport.Text = "Build Label Report"
            ' 
            ' LabelWidthSpinEdit
            ' 
            Me.LabelWidthSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.LabelWidthSpinEdit.Location = New System.Drawing.Point(104, 144)
            Me.LabelWidthSpinEdit.Name = "LabelWidthSpinEdit"
            Me.LabelWidthSpinEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.LabelWidthSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelWidthSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LabelWidthSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.LabelWidthSpinEdit.Properties.Mask.EditMask = "F"
            Me.LabelWidthSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.LabelWidthSpinEdit.Size = New System.Drawing.Size(305, 20)
            Me.LabelWidthSpinEdit.StyleController = Me.dataLayoutControl1
            Me.LabelWidthSpinEdit.TabIndex = 4
            ' 
            ' LabelHeightSpinEdit
            ' 
            Me.LabelHeightSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.LabelHeightSpinEdit.Location = New System.Drawing.Point(104, 168)
            Me.LabelHeightSpinEdit.Name = "LabelHeightSpinEdit"
            Me.LabelHeightSpinEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.LabelHeightSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelHeightSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LabelHeightSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.LabelHeightSpinEdit.Properties.Mask.EditMask = "F"
            Me.LabelHeightSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.LabelHeightSpinEdit.Size = New System.Drawing.Size(305, 20)
            Me.LabelHeightSpinEdit.StyleController = Me.dataLayoutControl1
            Me.LabelHeightSpinEdit.TabIndex = 5
            ' 
            ' VerticalPitchSpinEdit
            ' 
            Me.VerticalPitchSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.VerticalPitchSpinEdit.Location = New System.Drawing.Point(104, 226)
            Me.VerticalPitchSpinEdit.Name = "VerticalPitchSpinEdit"
            Me.VerticalPitchSpinEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.VerticalPitchSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.VerticalPitchSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.VerticalPitchSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.VerticalPitchSpinEdit.Properties.Mask.EditMask = "F"
            Me.VerticalPitchSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.VerticalPitchSpinEdit.Size = New System.Drawing.Size(305, 20)
            Me.VerticalPitchSpinEdit.StyleController = Me.dataLayoutControl1
            Me.VerticalPitchSpinEdit.TabIndex = 6
            ' 
            ' HorizontalPitchSpinEdit
            ' 
            Me.HorizontalPitchSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.HorizontalPitchSpinEdit.Location = New System.Drawing.Point(104, 202)
            Me.HorizontalPitchSpinEdit.Name = "HorizontalPitchSpinEdit"
            Me.HorizontalPitchSpinEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.HorizontalPitchSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.HorizontalPitchSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.HorizontalPitchSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.HorizontalPitchSpinEdit.Properties.Mask.EditMask = "F"
            Me.HorizontalPitchSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.HorizontalPitchSpinEdit.Size = New System.Drawing.Size(305, 20)
            Me.HorizontalPitchSpinEdit.StyleController = Me.dataLayoutControl1
            Me.HorizontalPitchSpinEdit.TabIndex = 7
            ' 
            ' BottomMarginSpinEdit
            ' 
            Me.BottomMarginSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.BottomMarginSpinEdit.Location = New System.Drawing.Point(104, 332)
            Me.BottomMarginSpinEdit.Name = "BottomMarginSpinEdit"
            Me.BottomMarginSpinEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.BottomMarginSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.BottomMarginSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.BottomMarginSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.BottomMarginSpinEdit.Properties.Mask.EditMask = "F"
            Me.BottomMarginSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.BottomMarginSpinEdit.Size = New System.Drawing.Size(305, 20)
            Me.BottomMarginSpinEdit.StyleController = Me.dataLayoutControl1
            Me.BottomMarginSpinEdit.TabIndex = 9
            ' 
            ' TopMarginSpinEdit
            ' 
            Me.TopMarginSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.TopMarginSpinEdit.Location = New System.Drawing.Point(104, 260)
            Me.TopMarginSpinEdit.Name = "TopMarginSpinEdit"
            Me.TopMarginSpinEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.TopMarginSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.TopMarginSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.TopMarginSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.TopMarginSpinEdit.Properties.Mask.EditMask = "F"
            Me.TopMarginSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.TopMarginSpinEdit.Size = New System.Drawing.Size(305, 20)
            Me.TopMarginSpinEdit.StyleController = Me.dataLayoutControl1
            Me.TopMarginSpinEdit.TabIndex = 10
            ' 
            ' LeftMarginSpinEdit
            ' 
            Me.LeftMarginSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.LeftMarginSpinEdit.Location = New System.Drawing.Point(104, 284)
            Me.LeftMarginSpinEdit.Name = "LeftMarginSpinEdit"
            Me.LeftMarginSpinEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.LeftMarginSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LeftMarginSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LeftMarginSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.LeftMarginSpinEdit.Properties.Mask.EditMask = "F"
            Me.LeftMarginSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.LeftMarginSpinEdit.Size = New System.Drawing.Size(305, 20)
            Me.LeftMarginSpinEdit.StyleController = Me.dataLayoutControl1
            Me.LeftMarginSpinEdit.TabIndex = 11
            ' 
            ' RightMarginSpinEdit
            ' 
            Me.RightMarginSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.RightMarginSpinEdit.Location = New System.Drawing.Point(104, 308)
            Me.RightMarginSpinEdit.Name = "RightMarginSpinEdit"
            Me.RightMarginSpinEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.RightMarginSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.RightMarginSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RightMarginSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.RightMarginSpinEdit.Properties.Mask.EditMask = "F"
            Me.RightMarginSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.RightMarginSpinEdit.Size = New System.Drawing.Size(305, 20)
            Me.RightMarginSpinEdit.StyleController = Me.dataLayoutControl1
            Me.RightMarginSpinEdit.TabIndex = 12
            ' 
            ' lookUpLabelProduct
            ' 
            Me.lookUpLabelProduct.Location = New System.Drawing.Point(104, 24)
            Me.lookUpLabelProduct.Name = "lookUpLabelProduct"
            Me.lookUpLabelProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpLabelProduct.Properties.View = Me.gridView1
            Me.lookUpLabelProduct.Size = New System.Drawing.Size(305, 20)
            Me.lookUpLabelProduct.StyleController = Me.dataLayoutControl1
            Me.lookUpLabelProduct.TabIndex = 4
            ' 
            ' gridView1
            ' 
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' lookUpProductNumber
            ' 
            Me.lookUpProductNumber.Location = New System.Drawing.Point(104, 48)
            Me.lookUpProductNumber.Name = "lookUpProductNumber"
            Me.lookUpProductNumber.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpProductNumber.Properties.View = Me.gridView2
            Me.lookUpProductNumber.Size = New System.Drawing.Size(305, 20)
            Me.lookUpProductNumber.StyleController = Me.dataLayoutControl1
            Me.lookUpProductNumber.TabIndex = 5
            ' 
            ' gridView2
            ' 
            Me.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridView2.OptionsView.ShowGroupPanel = False
            ' 
            ' UnitComboBox
            ' 
            Me.UnitComboBox.Location = New System.Drawing.Point(104, 96)
            Me.UnitComboBox.Name = "UnitComboBox"
            Me.UnitComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.UnitComboBox.Properties.NullText = "[EditValue is null]"
            Me.UnitComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.UnitComboBox.Size = New System.Drawing.Size(305, 20)
            Me.UnitComboBox.StyleController = Me.dataLayoutControl1
            Me.UnitComboBox.TabIndex = 19
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(433, 485)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup3, Me.layoutControlGroup4, Me.layoutControlGroup5, Me.layoutControlGroup6})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(413, 404)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForLabelWidth, Me.ItemForLabelHeight, Me.ItemForBottomMargin, Me.ItemForVerticalPitch, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.ItemForTopMargin, Me.ItemForLeftMargin, Me.ItemForRightMargin, Me.ItemForHorizontalPitch})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(413, 236)
            Me.layoutControlGroup3.TextVisible = False
            ' 
            ' ItemForLabelWidth
            ' 
            Me.ItemForLabelWidth.Control = Me.LabelWidthSpinEdit
            Me.ItemForLabelWidth.Location = New System.Drawing.Point(0, 0)
            Me.ItemForLabelWidth.Name = "ItemForLabelWidth"
            Me.ItemForLabelWidth.Size = New System.Drawing.Size(389, 24)
            Me.ItemForLabelWidth.Text = "Label Width"
            Me.ItemForLabelWidth.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' ItemForLabelHeight
            ' 
            Me.ItemForLabelHeight.Control = Me.LabelHeightSpinEdit
            Me.ItemForLabelHeight.Location = New System.Drawing.Point(0, 24)
            Me.ItemForLabelHeight.Name = "ItemForLabelHeight"
            Me.ItemForLabelHeight.Size = New System.Drawing.Size(389, 24)
            Me.ItemForLabelHeight.Text = "Label Height"
            Me.ItemForLabelHeight.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' ItemForBottomMargin
            ' 
            Me.ItemForBottomMargin.Control = Me.BottomMarginSpinEdit
            Me.ItemForBottomMargin.Location = New System.Drawing.Point(0, 188)
            Me.ItemForBottomMargin.Name = "ItemForBottomMargin"
            Me.ItemForBottomMargin.Size = New System.Drawing.Size(389, 24)
            Me.ItemForBottomMargin.Text = "Bottom Margin"
            Me.ItemForBottomMargin.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' ItemForVerticalPitch
            ' 
            Me.ItemForVerticalPitch.Control = Me.VerticalPitchSpinEdit
            Me.ItemForVerticalPitch.Location = New System.Drawing.Point(0, 82)
            Me.ItemForVerticalPitch.Name = "ItemForVerticalPitch"
            Me.ItemForVerticalPitch.Size = New System.Drawing.Size(389, 24)
            Me.ItemForVerticalPitch.Text = "Vertical Pitch"
            Me.ItemForVerticalPitch.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(389, 10)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 106)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(389, 10)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' ItemForTopMargin
            ' 
            Me.ItemForTopMargin.Control = Me.TopMarginSpinEdit
            Me.ItemForTopMargin.Location = New System.Drawing.Point(0, 116)
            Me.ItemForTopMargin.Name = "ItemForTopMargin"
            Me.ItemForTopMargin.Size = New System.Drawing.Size(389, 24)
            Me.ItemForTopMargin.Text = "Top Margin"
            Me.ItemForTopMargin.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' ItemForLeftMargin
            ' 
            Me.ItemForLeftMargin.Control = Me.LeftMarginSpinEdit
            Me.ItemForLeftMargin.Location = New System.Drawing.Point(0, 140)
            Me.ItemForLeftMargin.Name = "ItemForLeftMargin"
            Me.ItemForLeftMargin.Size = New System.Drawing.Size(389, 24)
            Me.ItemForLeftMargin.Text = "Left Margin"
            Me.ItemForLeftMargin.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' ItemForRightMargin
            ' 
            Me.ItemForRightMargin.Control = Me.RightMarginSpinEdit
            Me.ItemForRightMargin.Location = New System.Drawing.Point(0, 164)
            Me.ItemForRightMargin.Name = "ItemForRightMargin"
            Me.ItemForRightMargin.Size = New System.Drawing.Size(389, 24)
            Me.ItemForRightMargin.Text = "Right Margin"
            Me.ItemForRightMargin.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' ItemForHorizontalPitch
            ' 
            Me.ItemForHorizontalPitch.Control = Me.HorizontalPitchSpinEdit
            Me.ItemForHorizontalPitch.Location = New System.Drawing.Point(0, 58)
            Me.ItemForHorizontalPitch.Name = "ItemForHorizontalPitch"
            Me.ItemForHorizontalPitch.Size = New System.Drawing.Size(389, 24)
            Me.ItemForHorizontalPitch.Text = "Horizontal Pitch"
            Me.ItemForHorizontalPitch.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(413, 72)
            Me.layoutControlGroup4.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.lookUpLabelProduct
            Me.layoutControlItem1.CustomizationFormText = "Label Product"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(389, 24)
            Me.layoutControlItem1.Text = "Label Product"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.lookUpProductNumber
            Me.layoutControlItem2.CustomizationFormText = "Product Number"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(389, 24)
            Me.layoutControlItem2.Text = "Product Number"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem5})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 356)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(413, 48)
            Me.layoutControlGroup5.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.lookUpPaperType
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(389, 24)
            Me.layoutControlItem5.Text = "Page Size"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem7})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlGroup6.Name = "layoutControlGroup6"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(413, 48)
            Me.layoutControlGroup6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.UnitComboBox
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(389, 24)
            Me.layoutControlItem7.Text = "Unit"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.btnBuildReport
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 404)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(99, 26)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(413, 61)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(433, 485)
            Me.Controls.Add(Me.dataLayoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType(Me.lookUpPaperType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LabelWidthSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LabelHeightSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VerticalPitchSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HorizontalPitchSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BottomMarginSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TopMarginSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LeftMarginSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RightMarginSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lookUpLabelProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lookUpProductNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UnitComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForLabelWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForLabelHeight, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForBottomMargin, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForVerticalPitch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForTopMargin, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForLeftMargin, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForRightMargin, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForHorizontalPitch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private LabelWidthSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private LabelHeightSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private VerticalPitchSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private HorizontalPitchSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private BottomMarginSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private TopMarginSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private LeftMarginSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private RightMarginSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
        Private ItemForLabelWidth As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForLabelHeight As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForVerticalPitch As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForHorizontalPitch As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForTopMargin As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForBottomMargin As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForLeftMargin As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForRightMargin As DevExpress.XtraLayout.LayoutControlItem
        Private lookUpLabelProduct As DevExpress.XtraEditors.GridLookUpEdit
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private lookUpProductNumber As DevExpress.XtraEditors.GridLookUpEdit
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents btnBuildReport As DevExpress.XtraEditors.SimpleButton
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private lookUpPaperType As DevExpress.XtraEditors.GridLookUpEdit
        Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents UnitComboBox As DevExpress.XtraEditors.ComboBoxEdit
        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace