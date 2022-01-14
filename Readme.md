# GridView for MVC - How to add a column if the AutoGenerateColumns property is set to true

When the [AutoGenerateColumns](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView.AutoGenerateColumns) property is set to `true`, handle the [GridViewSettings.DataBound](http://docs.devexpress.devx/AspNetMvc/DevExpress.Web.Mvc.GridSettingsBase.DataBound) event to add a column to the GridView. Before adding the column, check whether a column already exists to avoid duplicate columns.

```cshtml
settings.DataBound = (sender, e) => {
    MVCxGridView grid = sender as MVCxGridView;
    if (grid.Columns.IndexOf(grid.Columns["CommandColumn"]) != -1)
        return;
    GridViewCommandColumn col = new GridViewCommandColumn();
    col.Name = "CommandColumn";
    col.ShowSelectCheckbox = true;
    col.VisibleIndex = 0;
    grid.Columns.Add(col);
};
```

## Files to Look At

- [GridPartial.cshtml](./CS/AddColumnAtRunTime/Views/Shared/GridPartial.cshtml)

## More Examples

- [GridView for Web Forms - How to add a column if the AutoGenerateColumns property is set to true](https://github.com/DevExpress-Examples/aspxgridview-how-to-add-a-column-if-the-autogeneratecolumns-property-is-set-to-true-e3587)