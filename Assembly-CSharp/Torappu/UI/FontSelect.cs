using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020036C5 RID: 14021
	[Token(Token = "0x20036C5")]
	[CreateAssetMenu(menuName = "Torappu/UI/FontSelect")]
	[Serializable]
	public class FontSelect : ScriptableObject
	{
		// Token: 0x06016478 RID: 91256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016478")]
		[Address(RVA = "0xEB49D0", Offset = "0xEB35D0", VA = "0x180EB49D0")]
		public Font GetFont(string fontName)
		{
			return null;
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x06016479 RID: 91257 RVA: 0x00090528 File Offset: 0x0008E728
		[Token(Token = "0x1700358B")]
		public ResourceOptions.ResLanguage language
		{
			[Token(Token = "0x6016479")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return ResourceOptions.ResLanguage.NONE;
			}
		}

		// Token: 0x0601647A RID: 91258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601647A")]
		[Address(RVA = "0xEB4B40", Offset = "0xEB3740", VA = "0x180EB4B40")]
		public FontSelect()
		{
		}

		// Token: 0x0401ACBC RID: 109756
		[Token(Token = "0x401ACBC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private ResourceOptions.ResLanguage _lan;

		// Token: 0x0401ACBD RID: 109757
		[Token(Token = "0x401ACBD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ReadOnly]
		private FontSelect.TheFont[] _fonts;

		// Token: 0x0401ACBE RID: 109758
		[Token(Token = "0x401ACBE")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Font> _fontdic;

		// Token: 0x020036C6 RID: 14022
		[Token(Token = "0x20036C6")]
		[Serializable]
		private class TheFont
		{
			// Token: 0x0601647B RID: 91259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601647B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TheFont()
			{
			}

			// Token: 0x0401ACBF RID: 109759
			[Token(Token = "0x401ACBF")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0401ACC0 RID: 109760
			[Token(Token = "0x401ACC0")]
			[FieldOffset(Offset = "0x18")]
			public Font font;
		}
	}
}
