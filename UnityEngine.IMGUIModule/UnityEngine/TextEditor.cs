using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	public class TextEditor
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public string text
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x59B7990", Offset = "0x59B6590", VA = "0x1859B7990")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x59B7B10", Offset = "0x59B6710", VA = "0x1859B7B10")]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00002DD8 File Offset: 0x00000FD8
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000088")]
		public Rect position
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x59B7970", Offset = "0x59B6570", VA = "0x1859B7970")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x59B7A20", Offset = "0x59B6620", VA = "0x1859B7A20")]
			set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x17000089")]
		internal virtual Rect localPosition
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x59B7960", Offset = "0x59B6560", VA = "0x1859B7960", Slot = "4")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00002E08 File Offset: 0x00001008
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008A")]
		public int cursorIndex
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x59B7940", Offset = "0x59B6540", VA = "0x1859B7940")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x59B79B0", Offset = "0x59B65B0", VA = "0x1859B79B0")]
			set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00002E20 File Offset: 0x00001020
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		public int selectIndex
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x59B7980", Offset = "0x59B6580", VA = "0x1859B7980")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x59B7AB0", Offset = "0x59B66B0", VA = "0x1859B7AB0")]
			set
			{
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x59B0310", Offset = "0x59AEF10", VA = "0x1859B0310")]
		private void ClearCursorPos()
		{
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x1700008C")]
		public int altCursorPosition
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x59B7930", Offset = "0x59B6530", VA = "0x1859B7930")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x59B7770", Offset = "0x59B6370", VA = "0x1859B7770")]
		[RequiredByNativeCode]
		public TextEditor()
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x59B4500", Offset = "0x59B3100", VA = "0x1859B4500")]
		public void OnFocus()
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x59B45D0", Offset = "0x59B31D0", VA = "0x1859B45D0")]
		public void OnLostFocus()
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x59B19C0", Offset = "0x59B05C0", VA = "0x1859B19C0")]
		private void GrabGraphicalCursorPos()
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x59B1C00", Offset = "0x59B0800", VA = "0x1859B1C00")]
		public bool HandleKeyEvent(Event e)
		{
			return default(bool);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x59B1AE0", Offset = "0x59B06E0", VA = "0x1859B1AE0")]
		[VisibleToOtherModules]
		internal bool HandleKeyEvent(Event e, bool textIsReadOnly)
		{
			return default(bool);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x59B0420", Offset = "0x59AF020", VA = "0x1859B0420")]
		public bool DeleteLineBack()
		{
			return default(bool);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x59B06E0", Offset = "0x59AF2E0", VA = "0x1859B06E0")]
		public bool DeleteWordBack()
		{
			return default(bool);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x59B07B0", Offset = "0x59AF3B0", VA = "0x1859B07B0")]
		public bool DeleteWordForward()
		{
			return default(bool);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x59B0880", Offset = "0x59AF480", VA = "0x1859B0880")]
		public bool Delete()
		{
			return default(bool);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x59B0150", Offset = "0x59AED50", VA = "0x1859B0150")]
		public bool CanPaste()
		{
			return default(bool);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x59B0070", Offset = "0x59AEC70", VA = "0x1859B0070")]
		public bool Backspace()
		{
			return default(bool);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x59B58C0", Offset = "0x59B44C0", VA = "0x1859B58C0")]
		public void SelectAll()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x59B6230", Offset = "0x59B4E30", VA = "0x1859B6230")]
		public void SelectNone()
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x1700008D")]
		public bool hasSelection
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x59B7950", Offset = "0x59B6550", VA = "0x1859B7950")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000283 RID: 643 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700008E")]
		public string SelectedText
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x59B78A0", Offset = "0x59B64A0", VA = "0x1859B78A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x59B0510", Offset = "0x59AF110", VA = "0x1859B0510")]
		public bool DeleteSelection()
		{
			return default(bool);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x59B5750", Offset = "0x59B4350", VA = "0x1859B5750")]
		public void ReplaceSelection(string replace)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x59B2700", Offset = "0x59B1300", VA = "0x1859B2700")]
		public void Insert(char c)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x59B3860", Offset = "0x59B2460", VA = "0x1859B3860")]
		public void MoveSelectionToAltCursor()
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x59B3730", Offset = "0x59B2330", VA = "0x1859B3730")]
		public void MoveRight()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x59B3070", Offset = "0x59B1C70", VA = "0x1859B3070")]
		public void MoveLeft()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x59B3DC0", Offset = "0x59B29C0", VA = "0x1859B3DC0")]
		public void MoveUp()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x59B2CC0", Offset = "0x59B18C0", VA = "0x1859B2CC0")]
		public void MoveDown()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x59B32B0", Offset = "0x59B1EB0", VA = "0x1859B32B0")]
		public void MoveLineStart()
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x59B3160", Offset = "0x59B1D60", VA = "0x1859B3160")]
		public void MoveLineEnd()
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x59B2FA0", Offset = "0x59B1BA0", VA = "0x1859B2FA0")]
		public void MoveGraphicalLineStart()
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x59B2ED0", Offset = "0x59B1AD0", VA = "0x1859B2ED0")]
		public void MoveGraphicalLineEnd()
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x59B3B10", Offset = "0x59B2710", VA = "0x1859B3B10")]
		public void MoveTextStart()
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x59B3A30", Offset = "0x59B2630", VA = "0x1859B3A30")]
		public void MoveTextEnd()
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x59B1D10", Offset = "0x59B0910", VA = "0x1859B1D10")]
		private int IndexOfEndOfLine(int startIndex)
		{
			return 0;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x59B35A0", Offset = "0x59B21A0", VA = "0x1859B35A0")]
		public void MoveParagraphForward()
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x59B33E0", Offset = "0x59B1FE0", VA = "0x1859B33E0")]
		public void MoveParagraphBackward()
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x59B2B40", Offset = "0x59B1740", VA = "0x1859B2B40")]
		public void MoveCursorToPosition(Vector2 cursorPosition)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x59B29E0", Offset = "0x59B15E0", VA = "0x1859B29E0")]
		protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x59B28F0", Offset = "0x59B14F0", VA = "0x1859B28F0")]
		public void MoveAltCursorToPosition(Vector2 cursorPosition)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x59B6770", Offset = "0x59B5370", VA = "0x1859B6770")]
		public void SelectToPosition(Vector2 cursorPosition)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x59B6190", Offset = "0x59B4D90", VA = "0x1859B6190")]
		public void SelectLeft()
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x59B6550", Offset = "0x59B5150", VA = "0x1859B6550")]
		public void SelectRight()
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x59B6E90", Offset = "0x59B5A90", VA = "0x1859B6E90")]
		public void SelectUp()
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x59B5F70", Offset = "0x59B4B70", VA = "0x1859B5F70")]
		public void SelectDown()
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x59B65F0", Offset = "0x59B51F0", VA = "0x1859B65F0")]
		public void SelectTextEnd()
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x59B6680", Offset = "0x59B5280", VA = "0x1859B6680")]
		public void SelectTextStart()
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x59B28E0", Offset = "0x59B14E0", VA = "0x1859B28E0")]
		public void MouseDragSelectsWholeWords(bool on)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x59B0410", Offset = "0x59AF010", VA = "0x1859B0410")]
		public void DblClickSnap(TextEditor.DblClickSnapping snapping)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x59B1880", Offset = "0x59B0480", VA = "0x1859B1880")]
		private int GetGraphicalLineStart(int p)
		{
			return 0;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x59B1730", Offset = "0x59B0330", VA = "0x1859B1730")]
		private int GetGraphicalLineEnd(int p)
		{
			return 0;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x59B1420", Offset = "0x59B0020", VA = "0x1859B1420")]
		private int FindNextSeperator(int startPos)
		{
			return 0;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x59B14C0", Offset = "0x59B00C0", VA = "0x1859B14C0")]
		private int FindPrevSeperator(int startPos)
		{
			return 0;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x59B4110", Offset = "0x59B2D10", VA = "0x1859B4110")]
		public void MoveWordRight()
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x59B3CC0", Offset = "0x59B28C0", VA = "0x1859B3CC0")]
		public void MoveToStartOfNextWord()
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x59B3BC0", Offset = "0x59B27C0", VA = "0x1859B3BC0")]
		public void MoveToEndOfPreviousWord()
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x59B6E10", Offset = "0x59B5A10", VA = "0x1859B6E10")]
		public void SelectToStartOfNextWord()
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x59B66F0", Offset = "0x59B52F0", VA = "0x1859B66F0")]
		public void SelectToEndOfPreviousWord()
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x59B01F0", Offset = "0x59AEDF0", VA = "0x1859B01F0")]
		private TextEditor.CharacterType ClassifyChar(int index)
		{
			return TextEditor.CharacterType.LetterLike;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x59B1560", Offset = "0x59B0160", VA = "0x1859B1560")]
		public int FindStartOfNextWord(int p)
		{
			return 0;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x59B1350", Offset = "0x59AFF50", VA = "0x1859B1350")]
		private int FindEndOfPreviousWord(int p)
		{
			return 0;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x59B3F90", Offset = "0x59B2B90", VA = "0x1859B3F90")]
		public void MoveWordLeft()
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x59B7130", Offset = "0x59B5D30", VA = "0x1859B7130")]
		public void SelectWordRight()
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x59B6F90", Offset = "0x59B5B90", VA = "0x1859B6F90")]
		public void SelectWordLeft()
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x59B10C0", Offset = "0x59AFCC0", VA = "0x1859B10C0")]
		public void ExpandSelectGraphicalLineStart()
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x59B0F90", Offset = "0x59AFB90", VA = "0x1859B0F90")]
		public void ExpandSelectGraphicalLineEnd()
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x59B6110", Offset = "0x59B4D10", VA = "0x1859B6110")]
		public void SelectGraphicalLineStart()
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x59B6090", Offset = "0x59B4C90", VA = "0x1859B6090")]
		public void SelectGraphicalLineEnd()
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x59B6420", Offset = "0x59B5020", VA = "0x1859B6420")]
		public void SelectParagraphForward()
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x59B62A0", Offset = "0x59B4EA0", VA = "0x1859B62A0")]
		public void SelectParagraphBackward()
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x59B5B00", Offset = "0x59B4700", VA = "0x1859B5B00")]
		public void SelectCurrentWord()
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x59B11F0", Offset = "0x59AFDF0", VA = "0x1859B11F0")]
		private int FindEndOfClassification(int p, TextEditor.Direction dir)
		{
			return 0;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x59B5990", Offset = "0x59B4590", VA = "0x1859B5990")]
		public void SelectCurrentParagraph()
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x59B72D0", Offset = "0x59B5ED0", VA = "0x1859B72D0")]
		public void UpdateScrollOffsetIfNeeded(Event evt)
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x59B7320", Offset = "0x59B5F20", VA = "0x1859B7320")]
		[VisibleToOtherModules]
		internal void UpdateScrollOffset()
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x59B0940", Offset = "0x59AF540", VA = "0x1859B0940")]
		public void DrawCursor(string newText)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x59B4730", Offset = "0x59B3330", VA = "0x1859B4730")]
		private bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly)
		{
			return default(bool);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x59B5870", Offset = "0x59B4470", VA = "0x1859B5870")]
		public void SaveBackup()
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x59B03E0", Offset = "0x59AEFE0", VA = "0x1859B03E0")]
		public bool Cut()
		{
			return default(bool);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x59B0320", Offset = "0x59AEF20", VA = "0x1859B0320")]
		public void Copy()
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x59B56C0", Offset = "0x59B42C0", VA = "0x1859B56C0")]
		private static string ReplaceNewlinesWithSpaces(string value)
		{
			return null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x59B4620", Offset = "0x59B3220", VA = "0x1859B4620")]
		public bool Paste()
		{
			return default(bool);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x59B2850", Offset = "0x59B1450", VA = "0x1859B2850")]
		private static void MapKey(string key, TextEditor.TextEditOp action)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x59B1D80", Offset = "0x59B0980", VA = "0x1859B1D80")]
		private void InitKeyActions()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x505F4F0", Offset = "0x505E0F0", VA = "0x18505F4F0")]
		public void DetectFocusChange()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x59B4390", Offset = "0x59B2F90", VA = "0x1859B4390", Slot = "5")]
		internal virtual void OnDetectFocusChange()
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		internal virtual void OnCursorIndexChange()
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		internal virtual void OnSelectIndexChange()
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x59B0190", Offset = "0x59AED90", VA = "0x1859B0190")]
		private void ClampTextIndex(ref int index)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x59B0E70", Offset = "0x59AFA70", VA = "0x1859B0E70")]
		private void EnsureValidCodePointIndex(ref int index)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x59B2760", Offset = "0x59B1360", VA = "0x1859B2760")]
		private bool IsValidCodePointIndex(int index)
		{
			return default(bool);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x59B5610", Offset = "0x59B4210", VA = "0x1859B5610")]
		private int PreviousCodePointIndex(int index)
		{
			return 0;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x59B42A0", Offset = "0x59B2EA0", VA = "0x1859B42A0")]
		private int NextCodePointIndex(int index)
		{
			return 0;
		}

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenKeyboard keyboardOnScreen;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x18")]
		public int controlID;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x20")]
		public GUIStyle style;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x28")]
		public bool multiline;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x29")]
		public bool hasHorizontalCursorPos;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x2A")]
		public bool isPasswordField;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x2B")]
		internal bool m_HasFocus;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 scrollOffset;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x38")]
		private GUIContent m_Content;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x40")]
		private Rect m_Position;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x50")]
		private int m_CursorIndex;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x54")]
		private int m_SelectIndex;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_RevealCursor;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x5C")]
		public Vector2 graphicalCursorPos;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x64")]
		public Vector2 graphicalSelectCursorPos;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_MouseDragSelectsWholeWords;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x70")]
		private int m_DblClickInitPos;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x74")]
		private TextEditor.DblClickSnapping m_DblClickSnap;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x75")]
		private bool m_bJustSelected;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x78")]
		private int m_iAltCursorPos;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x80")]
		private string oldText;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x88")]
		private int oldPos;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x8C")]
		private int oldSelectPos;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Event, TextEditor.TextEditOp> s_Keyactions;

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		public enum DblClickSnapping : byte
		{
			// Token: 0x0400012C RID: 300
			[Token(Token = "0x400012C")]
			WORDS,
			// Token: 0x0400012D RID: 301
			[Token(Token = "0x400012D")]
			PARAGRAPHS
		}

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x200002D")]
		private enum CharacterType
		{
			// Token: 0x0400012F RID: 303
			[Token(Token = "0x400012F")]
			LetterLike,
			// Token: 0x04000130 RID: 304
			[Token(Token = "0x4000130")]
			Symbol,
			// Token: 0x04000131 RID: 305
			[Token(Token = "0x4000131")]
			Symbol2,
			// Token: 0x04000132 RID: 306
			[Token(Token = "0x4000132")]
			WhiteSpace
		}

		// Token: 0x0200002E RID: 46
		[Token(Token = "0x200002E")]
		private enum Direction
		{
			// Token: 0x04000134 RID: 308
			[Token(Token = "0x4000134")]
			Forward,
			// Token: 0x04000135 RID: 309
			[Token(Token = "0x4000135")]
			Backward
		}

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		private enum TextEditOp
		{
			// Token: 0x04000137 RID: 311
			[Token(Token = "0x4000137")]
			MoveLeft,
			// Token: 0x04000138 RID: 312
			[Token(Token = "0x4000138")]
			MoveRight,
			// Token: 0x04000139 RID: 313
			[Token(Token = "0x4000139")]
			MoveUp,
			// Token: 0x0400013A RID: 314
			[Token(Token = "0x400013A")]
			MoveDown,
			// Token: 0x0400013B RID: 315
			[Token(Token = "0x400013B")]
			MoveLineStart,
			// Token: 0x0400013C RID: 316
			[Token(Token = "0x400013C")]
			MoveLineEnd,
			// Token: 0x0400013D RID: 317
			[Token(Token = "0x400013D")]
			MoveTextStart,
			// Token: 0x0400013E RID: 318
			[Token(Token = "0x400013E")]
			MoveTextEnd,
			// Token: 0x0400013F RID: 319
			[Token(Token = "0x400013F")]
			MovePageUp,
			// Token: 0x04000140 RID: 320
			[Token(Token = "0x4000140")]
			MovePageDown,
			// Token: 0x04000141 RID: 321
			[Token(Token = "0x4000141")]
			MoveGraphicalLineStart,
			// Token: 0x04000142 RID: 322
			[Token(Token = "0x4000142")]
			MoveGraphicalLineEnd,
			// Token: 0x04000143 RID: 323
			[Token(Token = "0x4000143")]
			MoveWordLeft,
			// Token: 0x04000144 RID: 324
			[Token(Token = "0x4000144")]
			MoveWordRight,
			// Token: 0x04000145 RID: 325
			[Token(Token = "0x4000145")]
			MoveParagraphForward,
			// Token: 0x04000146 RID: 326
			[Token(Token = "0x4000146")]
			MoveParagraphBackward,
			// Token: 0x04000147 RID: 327
			[Token(Token = "0x4000147")]
			MoveToStartOfNextWord,
			// Token: 0x04000148 RID: 328
			[Token(Token = "0x4000148")]
			MoveToEndOfPreviousWord,
			// Token: 0x04000149 RID: 329
			[Token(Token = "0x4000149")]
			SelectLeft,
			// Token: 0x0400014A RID: 330
			[Token(Token = "0x400014A")]
			SelectRight,
			// Token: 0x0400014B RID: 331
			[Token(Token = "0x400014B")]
			SelectUp,
			// Token: 0x0400014C RID: 332
			[Token(Token = "0x400014C")]
			SelectDown,
			// Token: 0x0400014D RID: 333
			[Token(Token = "0x400014D")]
			SelectTextStart,
			// Token: 0x0400014E RID: 334
			[Token(Token = "0x400014E")]
			SelectTextEnd,
			// Token: 0x0400014F RID: 335
			[Token(Token = "0x400014F")]
			SelectPageUp,
			// Token: 0x04000150 RID: 336
			[Token(Token = "0x4000150")]
			SelectPageDown,
			// Token: 0x04000151 RID: 337
			[Token(Token = "0x4000151")]
			ExpandSelectGraphicalLineStart,
			// Token: 0x04000152 RID: 338
			[Token(Token = "0x4000152")]
			ExpandSelectGraphicalLineEnd,
			// Token: 0x04000153 RID: 339
			[Token(Token = "0x4000153")]
			SelectGraphicalLineStart,
			// Token: 0x04000154 RID: 340
			[Token(Token = "0x4000154")]
			SelectGraphicalLineEnd,
			// Token: 0x04000155 RID: 341
			[Token(Token = "0x4000155")]
			SelectWordLeft,
			// Token: 0x04000156 RID: 342
			[Token(Token = "0x4000156")]
			SelectWordRight,
			// Token: 0x04000157 RID: 343
			[Token(Token = "0x4000157")]
			SelectToEndOfPreviousWord,
			// Token: 0x04000158 RID: 344
			[Token(Token = "0x4000158")]
			SelectToStartOfNextWord,
			// Token: 0x04000159 RID: 345
			[Token(Token = "0x4000159")]
			SelectParagraphBackward,
			// Token: 0x0400015A RID: 346
			[Token(Token = "0x400015A")]
			SelectParagraphForward,
			// Token: 0x0400015B RID: 347
			[Token(Token = "0x400015B")]
			Delete,
			// Token: 0x0400015C RID: 348
			[Token(Token = "0x400015C")]
			Backspace,
			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400015D")]
			DeleteWordBack,
			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			DeleteWordForward,
			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			DeleteLineBack,
			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			Cut,
			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000161")]
			Copy,
			// Token: 0x04000162 RID: 354
			[Token(Token = "0x4000162")]
			Paste,
			// Token: 0x04000163 RID: 355
			[Token(Token = "0x4000163")]
			SelectAll,
			// Token: 0x04000164 RID: 356
			[Token(Token = "0x4000164")]
			SelectNone,
			// Token: 0x04000165 RID: 357
			[Token(Token = "0x4000165")]
			ScrollStart,
			// Token: 0x04000166 RID: 358
			[Token(Token = "0x4000166")]
			ScrollEnd,
			// Token: 0x04000167 RID: 359
			[Token(Token = "0x4000167")]
			ScrollPageUp,
			// Token: 0x04000168 RID: 360
			[Token(Token = "0x4000168")]
			ScrollPageDown
		}
	}
}
