using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	[AddComponentMenu("CRIWARE/Library Initializer")]
	public class CriWareInitializer : CriMonoBehaviour
	{
		// Token: 0x060007CC RID: 1996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x3705BC0", Offset = "0x37047C0", VA = "0x183705BC0")]
		private void Awake()
		{
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x36D3B90", Offset = "0x36D2790", VA = "0x1836D3B90", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Start()
		{
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x3706C90", Offset = "0x3705890", VA = "0x183706C90")]
		private void OnDestroy()
		{
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x3706880", Offset = "0x3705480", VA = "0x183706880")]
		public void Initialize()
		{
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x3706C90", Offset = "0x3705890", VA = "0x183706C90")]
		public void Shutdown()
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000040DC File Offset: 0x000022DC
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x3706C40", Offset = "0x3705840", VA = "0x183706C40")]
		public static bool IsInitialized()
		{
			return default(bool);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x3705AF0", Offset = "0x37046F0", VA = "0x183705AF0")]
		public static void AddAudioEffectInterface(IntPtr effect_interface)
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000040F4 File Offset: 0x000022F4
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x3706260", Offset = "0x3704E60", VA = "0x183706260")]
		public static bool InitializeFileSystem(CriFsConfig config)
		{
			return default(bool);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0000410C File Offset: 0x0000230C
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x3705BF0", Offset = "0x37047F0", VA = "0x183705BF0")]
		public static bool InitializeAtom(CriAtomConfig config)
		{
			return default(bool);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00004124 File Offset: 0x00002324
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x37064E0", Offset = "0x37050E0", VA = "0x1837064E0")]
		public static bool InitializeMana(CriManaConfig config)
		{
			return default(bool);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x3706DA0", Offset = "0x37059A0", VA = "0x183706DA0")]
		private void OnValidate()
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x3706DA0", Offset = "0x37059A0", VA = "0x183706DA0")]
		private void ValidateConfigEditorForNotPublic()
		{
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void ValidateConfigForNotPublic()
		{
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x3706DA0", Offset = "0x37059A0", VA = "0x183706DA0")]
		private void ValidateConfigEditor()
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void ValidateConfig()
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x3706E10", Offset = "0x3705A10", VA = "0x183706E10")]
		public CriWareInitializer()
		{
		}

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x28")]
		public bool initializesFileSystem;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x30")]
		public CriFsConfig fileSystemConfig;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x38")]
		public bool initializesAtom;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x40")]
		public CriAtomConfig atomConfig;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x48")]
		public bool initializesMana;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x50")]
		public CriManaConfig manaConfig;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x58")]
		public bool useDecrypter;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x60")]
		public CriWareDecrypter.Config DecrypterConfig;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x68")]
		public bool dontInitializeOnAwake;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x69")]
		public bool dontDestroyOnLoad;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x0")]
		private static int initializationCount;
	}
}
