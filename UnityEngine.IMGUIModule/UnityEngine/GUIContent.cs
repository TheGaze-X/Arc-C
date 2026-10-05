using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[NativeHeader("Modules/IMGUI/GUIContent.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[Serializable]
	[StructLayout(0)]
	public class GUIContent
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public string text
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public Texture image
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x4893C50", Offset = "0x4892850", VA = "0x184893C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public string tooltip
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x5911BE0", Offset = "0x59107E0", VA = "0x185911BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x598E030", Offset = "0x598CC30", VA = "0x18598E030")]
		public GUIContent()
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x598E100", Offset = "0x598CD00", VA = "0x18598E100")]
		public GUIContent(string text)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x598E0A0", Offset = "0x598CCA0", VA = "0x18598E0A0")]
		public GUIContent(Texture image)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x598DE90", Offset = "0x598CA90", VA = "0x18598DE90")]
		public GUIContent(string text, Texture image, string tooltip)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x598DF60", Offset = "0x598CB60", VA = "0x18598DF60")]
		public GUIContent(GUIContent src)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x598D810", Offset = "0x598C410", VA = "0x18598D810")]
		internal static GUIContent Temp(string t)
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x598D8D0", Offset = "0x598C4D0", VA = "0x18598D8D0")]
		internal static GUIContent Temp(Texture i)
		{
			return null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x598D4B0", Offset = "0x598C0B0", VA = "0x18598D4B0")]
		internal static void ClearStaticCache()
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x598D9A0", Offset = "0x598C5A0", VA = "0x18598D9A0")]
		internal static GUIContent[] Temp(string[] texts)
		{
			return null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x598D610", Offset = "0x598C210", VA = "0x18598D610")]
		internal static GUIContent[] Temp(Texture[] images)
		{
			return null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x598DBA0", Offset = "0x598C7A0", VA = "0x18598DBA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Text;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture m_Image;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_Tooltip;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly GUIContent s_Text;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly GUIContent s_Image;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly GUIContent s_TextImage;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static GUIContent none;
	}
}
