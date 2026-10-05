using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook.Editor
{
	// Token: 0x02006737 RID: 26423
	[Token(Token = "0x2006737")]
	public class HandBookV2EditorForceCardView : MonoBehaviour
	{
		// Token: 0x170059C0 RID: 22976
		// (get) Token: 0x06025E44 RID: 155204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059C0")]
		public string editCardColor
		{
			[Token(Token = "0x6025E44")]
			[Address(RVA = "0x20D02D0", Offset = "0x20CEED0", VA = "0x1820D02D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025E45 RID: 155205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E45")]
		[Address(RVA = "0x20CF9C0", Offset = "0x20CE5C0", VA = "0x1820CF9C0")]
		public void Render(HandBookV2ForceData forceData)
		{
		}

		// Token: 0x06025E46 RID: 155206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E46")]
		[Address(RVA = "0x20D0150", Offset = "0x20CED50", VA = "0x1820D0150")]
		public void _UpdateColor()
		{
		}

		// Token: 0x06025E47 RID: 155207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E47")]
		[Address(RVA = "0x20CFE60", Offset = "0x20CEA60", VA = "0x1820CFE60")]
		public void UpdateColor(Color? color, Color? cardColor)
		{
		}

		// Token: 0x06025E48 RID: 155208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E48")]
		[Address(RVA = "0x20D0000", Offset = "0x20CEC00", VA = "0x1820D0000")]
		private void _ClearColor()
		{
		}

		// Token: 0x06025E49 RID: 155209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E49")]
		[Address(RVA = "0x20CFE00", Offset = "0x20CEA00", VA = "0x1820CFE00")]
		public void SetRaycast(bool canRaycast)
		{
		}

		// Token: 0x06025E4A RID: 155210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E4A")]
		[Address(RVA = "0x20CFE30", Offset = "0x20CEA30", VA = "0x1820CFE30")]
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x170059C1 RID: 22977
		// (get) Token: 0x06025E4B RID: 155211 RVA: 0x000C95A0 File Offset: 0x000C77A0
		// (set) Token: 0x06025E4C RID: 155212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059C1")]
		public Vector2 pos
		{
			[Token(Token = "0x6025E4B")]
			[Address(RVA = "0x20D0370", Offset = "0x20CEF70", VA = "0x1820D0370")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6025E4C")]
			[Address(RVA = "0x20D03D0", Offset = "0x20CEFD0", VA = "0x1820D03D0")]
			set
			{
			}
		}

		// Token: 0x170059C2 RID: 22978
		// (get) Token: 0x06025E4D RID: 155213 RVA: 0x000C95B8 File Offset: 0x000C77B8
		// (set) Token: 0x06025E4E RID: 155214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059C2")]
		public float scale
		{
			[Token(Token = "0x6025E4D")]
			[Address(RVA = "0x20D03A0", Offset = "0x20CEFA0", VA = "0x1820D03A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6025E4E")]
			[Address(RVA = "0x20D0410", Offset = "0x20CF010", VA = "0x1820D0410")]
			set
			{
			}
		}

		// Token: 0x06025E4F RID: 155215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E4F")]
		[Address(RVA = "0x20CFE20", Offset = "0x20CEA20", VA = "0x1820CFE20")]
		public void SetSelect(bool isSelect)
		{
		}

		// Token: 0x06025E50 RID: 155216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E50")]
		[Address(RVA = "0x20CF670", Offset = "0x20CE270", VA = "0x1820CF670")]
		public void OnBeginMove()
		{
		}

		// Token: 0x06025E51 RID: 155217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E51")]
		[Address(RVA = "0x20CF8A0", Offset = "0x20CE4A0", VA = "0x1820CF8A0")]
		public void OnMove(Vector2 delta)
		{
		}

		// Token: 0x06025E52 RID: 155218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E52")]
		[Address(RVA = "0x20CF790", Offset = "0x20CE390", VA = "0x1820CF790")]
		public void OnClick()
		{
		}

		// Token: 0x06025E53 RID: 155219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E53")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookV2EditorForceCardView()
		{
		}

		// Token: 0x040354BE RID: 218302
		[Token(Token = "0x40354BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textForceName;

		// Token: 0x040354BF RID: 218303
		[Token(Token = "0x40354BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textForceCode;

		// Token: 0x040354C0 RID: 218304
		[Token(Token = "0x40354C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgCollect;

		// Token: 0x040354C1 RID: 218305
		[Token(Token = "0x40354C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgCharCount;

		// Token: 0x040354C2 RID: 218306
		[Token(Token = "0x40354C2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCharCount;

		// Token: 0x040354C3 RID: 218307
		[Token(Token = "0x40354C3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040354C4 RID: 218308
		[Token(Token = "0x40354C4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _selectGo;

		// Token: 0x040354C5 RID: 218309
		[Token(Token = "0x40354C5")]
		[FieldOffset(Offset = "0x50")]
		private HandBookV2ForceData m_forceData;

		// Token: 0x040354C6 RID: 218310
		[Token(Token = "0x40354C6")]
		[FieldOffset(Offset = "0x58")]
		private Color? m_editColor;

		// Token: 0x040354C7 RID: 218311
		[Token(Token = "0x40354C7")]
		[FieldOffset(Offset = "0x6C")]
		private Color? m_editCardColor;

		// Token: 0x040354C8 RID: 218312
		[Token(Token = "0x40354C8")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 m_startPos;
	}
}
