using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020037FD RID: 14333
	[Token(Token = "0x20037FD")]
	[RequireComponent(typeof(Text))]
	public class UIFontSizeVerticalFitter : MonoBehaviour
	{
		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x06016B44 RID: 92996 RVA: 0x00092700 File Offset: 0x00090900
		// (set) Token: 0x06016B45 RID: 92997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003645")]
		[Inspect]
		public int minFontSize
		{
			[Token(Token = "0x6016B44")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016B45")]
			[Address(RVA = "0xF14420", Offset = "0xF13020", VA = "0x180F14420")]
			set
			{
			}
		}

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x06016B46 RID: 92998 RVA: 0x00092718 File Offset: 0x00090918
		// (set) Token: 0x06016B47 RID: 92999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003646")]
		[Inspect]
		public int maxFontSize
		{
			[Token(Token = "0x6016B46")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6016B47")]
			[Address(RVA = "0xF143F0", Offset = "0xF12FF0", VA = "0x180F143F0")]
			set
			{
			}
		}

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x06016B48 RID: 93000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003647")]
		public Text text
		{
			[Token(Token = "0x6016B48")]
			[Address(RVA = "0xF14350", Offset = "0xF12F50", VA = "0x180F14350")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x06016B49 RID: 93001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003648")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6016B49")]
			[Address(RVA = "0xF142B0", Offset = "0xF12EB0", VA = "0x180F142B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016B4A RID: 93002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B4A")]
		[Address(RVA = "0xF13C40", Offset = "0xF12840", VA = "0x180F13C40")]
		[Inspect(Level = 2)]
		public void AutoFit()
		{
		}

		// Token: 0x06016B4B RID: 93003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B4B")]
		[Address(RVA = "0xF14290", Offset = "0xF12E90", VA = "0x180F14290")]
		public UIFontSizeVerticalFitter()
		{
		}

		// Token: 0x0401B5C9 RID: 112073
		[Token(Token = "0x401B5C9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private int _minFontSize;

		// Token: 0x0401B5CA RID: 112074
		[Token(Token = "0x401B5CA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[HideInInspector]
		private int _maxFontSize;

		// Token: 0x0401B5CB RID: 112075
		[Token(Token = "0x401B5CB")]
		[FieldOffset(Offset = "0x20")]
		private Text m_text;

		// Token: 0x0401B5CC RID: 112076
		[Token(Token = "0x401B5CC")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_rectTransform;
	}
}
