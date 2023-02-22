using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Drawing.Text;

static class GraphicsExtension
{
    private static GraphicsPath GenerateRoundedRectangle(
        this Graphics graphics,
        RectangleF rectangle,
        float radius)
    {
        float diameter;
        GraphicsPath path = new GraphicsPath();
        if (radius <= 0.0F)
        {
            path.AddRectangle(rectangle);
            path.CloseFigure();
            return path;
        }
        else
        {
            if (radius >= (Math.Min(rectangle.Width, rectangle.Height)) / 2.0)
                return graphics.GenerateCapsule(rectangle);
            diameter = radius * 2.0F;
            SizeF sizeF = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(rectangle.Location, sizeF);
            path.AddArc(arc, 180, 90);
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
        }
        return path;
    }
    private static GraphicsPath GenerateCapsule(
        this Graphics graphics,
        RectangleF baseRect)
    {
        float diameter;
        RectangleF arc;
        GraphicsPath path = new GraphicsPath();
        try
        {
            if (baseRect.Width > baseRect.Height)
            {
                diameter = baseRect.Height;
                SizeF sizeF = new SizeF(diameter, diameter);
                arc = new RectangleF(baseRect.Location, sizeF);
                path.AddArc(arc, 90, 180);
                arc.X = baseRect.Right - diameter;
                path.AddArc(arc, 270, 180);
            }
            else if (baseRect.Width < baseRect.Height)
            {
                diameter = baseRect.Width;
                SizeF sizeF = new SizeF(diameter, diameter);
                arc = new RectangleF(baseRect.Location, sizeF);
                path.AddArc(arc, 180, 180);
                arc.Y = baseRect.Bottom - diameter;
                path.AddArc(arc, 0, 180);
            }
            else path.AddEllipse(baseRect);
        }
        catch { path.AddEllipse(baseRect); }
        finally { path.CloseFigure(); }
        return path;
    }

    /// <summary>
    /// Draws a rounded rectangle specified by a pair of coordinates, a width, a height and the radius 
    /// for the arcs that make the rounded edges.
    /// </summary>
    /// <param name="brush">System.Drawing.Pen that determines the color, width and style of the rectangle.</param>
    /// <param name="x">The x-coordinate of the upper-left corner of the rectangle to draw.</param>
    /// <param name="y">The y-coordinate of the upper-left corner of the rectangle to draw.</param>
    /// <param name="width">Width of the rectangle to draw.</param>
    /// <param name="height">Height of the rectangle to draw.</param>
    /// <param name="radius">The radius of the arc used for the rounded edges.</param>

    public static void DrawRoundedRectangle(
        this Graphics graphics,
        Pen pen,
        float x,
        float y,
        float width,
        float height,
        float radius)
    {
        RectangleF rectangle = new RectangleF(x, y, width, height);
        GraphicsPath path = graphics.GenerateRoundedRectangle(rectangle, radius);
        SmoothingMode old = graphics.SmoothingMode;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.DrawPath(pen, path);
        graphics.SmoothingMode = old;
    }

    /// <summary>
    /// Draws a rounded rectangle specified by a pair of coordinates, a width, a height and the radius 
    /// for the arcs that make the rounded edges.
    /// </summary>
    /// <param name="brush">System.Drawing.Pen that determines the color, width and style of the rectangle.</param>
    /// <param name="x">The x-coordinate of the upper-left corner of the rectangle to draw.</param>
    /// <param name="y">The y-coordinate of the upper-left corner of the rectangle to draw.</param>
    /// <param name="width">Width of the rectangle to draw.</param>
    /// <param name="height">Height of the rectangle to draw.</param>
    /// <param name="radius">The radius of the arc used for the rounded edges.</param>

    public static void DrawRoundedRectangle(
        this Graphics graphics,
        Pen pen,
        int x,
        int y,
        int width,
        int height,
        int radius)
    {
        graphics.DrawRoundedRectangle(
            pen,
            Convert.ToSingle(x),
            Convert.ToSingle(y),
            Convert.ToSingle(width),
            Convert.ToSingle(height),
            Convert.ToSingle(radius));
    }

    /// <summary>
    /// Fills the interior of a rounded rectangle specified by a pair of coordinates, a width, a height
    /// and the radius for the arcs that make the rounded edges.
    /// </summary>
    /// <param name="brush">System.Drawing.Brush that determines the characteristics of the fill.</param>
    /// <param name="x">The x-coordinate of the upper-left corner of the rectangle to fill.</param>
    /// <param name="y">The y-coordinate of the upper-left corner of the rectangle to fill.</param>
    /// <param name="width">Width of the rectangle to fill.</param>
    /// <param name="height">Height of the rectangle to fill.</param>
    /// <param name="radius">The radius of the arc used for the rounded edges.</param>

    public static void FillRoundedRectangle(
        this Graphics graphics,
        Brush brush,
        float x,
        float y,
        float width,
        float height,
        float radius)
    {
        RectangleF rectangle = new RectangleF(x, y, width, height);
        GraphicsPath path = graphics.GenerateRoundedRectangle(rectangle, radius);
        SmoothingMode old = graphics.SmoothingMode;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.FillPath(brush, path);
        graphics.SmoothingMode = old;
    }

    /// <summary>
    /// Fills the interior of a rounded rectangle specified by a pair of coordinates, a width, a height
    /// and the radius for the arcs that make the rounded edges.
    /// </summary>
    /// <param name="brush">System.Drawing.Brush that determines the characteristics of the fill.</param>
    /// <param name="x">The x-coordinate of the upper-left corner of the rectangle to fill.</param>
    /// <param name="y">The y-coordinate of the upper-left corner of the rectangle to fill.</param>
    /// <param name="width">Width of the rectangle to fill.</param>
    /// <param name="height">Height of the rectangle to fill.</param>
    /// <param name="radius">The radius of the arc used for the rounded edges.</param>

    public static void FillRoundedRectangle(
        this Graphics graphics,
        Brush brush,
        int x,
        int y,
        int width,
        int height,
        int radius)
    {
        graphics.FillRoundedRectangle(
            brush,
            Convert.ToSingle(x),
            Convert.ToSingle(y),
            Convert.ToSingle(width),
            Convert.ToSingle(height),
            Convert.ToSingle(radius));
    }
}

public class BaseControl
{
    private static readonly ContentAlignment anyRight = ContentAlignment.TopRight | ContentAlignment.MiddleRight | ContentAlignment.BottomRight;
    private static readonly ContentAlignment anyBottom = ContentAlignment.BottomLeft | ContentAlignment.BottomCenter | ContentAlignment.BottomRight;
    private static readonly ContentAlignment anyCenter = ContentAlignment.TopCenter | ContentAlignment.MiddleCenter | ContentAlignment.BottomCenter;
    private static readonly ContentAlignment anyMiddle = ContentAlignment.MiddleLeft | ContentAlignment.MiddleCenter | ContentAlignment.MiddleRight;


    static StringAlignment TranslateAlignment(ContentAlignment align)
    {
        StringAlignment result;
        if ((align & anyRight) != 0)
            result = StringAlignment.Far;
        else if ((align & anyCenter) != 0)
            result = StringAlignment.Center;
        else
            result = StringAlignment.Near;
        return result;
    }

    static StringAlignment TranslateLineAlignment(ContentAlignment align)
    {
        StringAlignment result;
        if ((align & anyBottom) != 0)
        {
            result = StringAlignment.Far;
        }
        else if ((align & anyMiddle) != 0)
        {
            result = StringAlignment.Center;
        }
        else
        {
            result = StringAlignment.Near;
        }
        return result;
    }

    static StringFormat StringFormatForAlignment(ContentAlignment align)
    {
        StringFormat output = new StringFormat();
        output.Alignment = TranslateAlignment(align);
        output.LineAlignment = TranslateLineAlignment(align);
        return output;
    }

    public static StringFormat CreateStringFormat(SansationRoundButton ctl, ContentAlignment textAlign, bool showEllipsis, bool useMnemonic)
    {
        StringFormat stringFormat = StringFormatForAlignment(textAlign);

        // Adjust string format for Rtl controls
        if (ctl.RightToLeft == RightToLeft.Yes)
        {
            stringFormat.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
        }

        if (showEllipsis)
        {
            stringFormat.Trimming = StringTrimming.EllipsisCharacter;
            stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
        }

        if (!useMnemonic)
        {
            stringFormat.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
        }
        else if (ctl.ShowKeyboardCues)
        {
            stringFormat.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;
        }
        else
        {
            stringFormat.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Hide;
        }

        if (ctl.AutoSize)
        {
            stringFormat.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
        }

        return stringFormat;
    }
}

public class SansationRoundButton : Button
{
    #region members

    private TextRenderingHint _hint = TextRenderingHint.AntiAlias;
    private const int FlagMouseOver = 0x0001;
    private const int FlagMouseDown = 0x0002;
    private int state = 0;

    #endregion

    #region Constructor

    public SansationRoundButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.Font = new System.Drawing.Font("Sansation", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.UseVisualStyleBackColor = true;
        this.Cursor = Cursors.Hand;
    }

    #endregion

    #region Internal methods and properties

    internal bool OwnerDraw
    {
        get
        {
            return FlatStyle != FlatStyle.System;
        }
    }

    internal bool MouseIsOver
    {
        get
        {
            return GetFlag(FlagMouseOver);
        }
    }

    #endregion

    #region Private methods

    private bool GetFlag(int flag)
    {
        return ((state & flag) == flag);
    }

    private void SetFlag(int flag, bool value)
    {
        bool oldValue = ((state & flag) != 0);

        if (value)
            state |= flag;
        else
            state &= ~flag;

        if (OwnerDraw && (flag & FlagMouseDown) != 0 && value != oldValue)
            AccessibilityNotifyClients(AccessibleEvents.StateChange, -1);
    }

    #endregion

    #region Overrides

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);

        SetFlag(FlagMouseOver, true);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        SetFlag(FlagMouseOver, false);
    }

    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        e.Graphics.Clear(Color.Black);
        e.Graphics.TextRenderingHint = this.TextRenderingHint;
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Color backColor = this.MouseIsOver ? this.BackColorMouseOver : this.BackColor;
        Color borderColor = this.MouseIsOver ? this.BorderColorMouseOver : this.BorderColor;

        e.Graphics.DrawRoundedRectangle(new Pen(borderColor), 0, 0, this.Width - 1, this.Height - 1, 10);
        e.Graphics.FillRoundedRectangle(new SolidBrush(backColor), 0, 0, this.Width - 1, this.Height - 1, 10);

        StringFormat sr = BaseControl.CreateStringFormat(this, this.TextAlign, false, this.UseMnemonic);

        e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(ForeColor), ClientRectangle, sr);
    }

    #endregion

    #region public properties

    public TextRenderingHint TextRenderingHint
    {
        get { return this._hint; }
        set { this._hint = value; }
    }

    public new bool ShowKeyboardCues
    {
        get
        {
            return base.ShowKeyboardCues;
        }
    }

    public Color BackColorMouseOver { get; set; } = Color.Red;

    public Color BorderColor { get; set; } = Color.Black;
    public Color BorderColorMouseOver { get; set; } = Color.Black;

    #endregion
}

