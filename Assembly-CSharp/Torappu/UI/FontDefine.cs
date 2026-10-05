using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020036C4 RID: 14020
	[Token(Token = "0x20036C4")]
	[CreateAssetMenu(menuName = "Torappu/UI/FontDefine")]
	[Serializable]
	public class FontDefine : ScriptableObject
	{
		// Token: 0x06016475 RID: 91253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016475")]
		[Address(RVA = "0xEB47D0", Offset = "0xEB33D0", VA = "0x180EB47D0")]
		public string GetFontGUID(string fontName, ResourceOptions.ResLanguage lan)
		{
			return null;
		}

		// Token: 0x06016476 RID: 91254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016476")]
		[Address(RVA = "0xEB4910", Offset = "0xEB3510", VA = "0x180EB4910")]
		private LanFonts _GetLanFont(ResourceOptions.ResLanguage lan)
		{
			return null;
		}

		// Token: 0x06016477 RID: 91255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016477")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public FontDefine()
		{
		}

		// Token: 0x0401ACBA RID: 109754
		[Token(Token = "0x401ACBA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private string[] _fontTypes;

		// Token: 0x0401ACBB RID: 109755
		[Token(Token = "0x401ACBB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ReadOnly]
		private LanFonts[] _lanFonts;
	}
}
