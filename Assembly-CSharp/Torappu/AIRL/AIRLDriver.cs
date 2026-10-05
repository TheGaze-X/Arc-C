using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AIRL
{
	// Token: 0x0200202A RID: 8234
	[Token(Token = "0x200202A")]
	public sealed class AIRLDriver : PersistentSingleton<AIRLDriver>
	{
		// Token: 0x0600CAEA RID: 51946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAEA")]
		[Address(RVA = "0x34BCB70", Offset = "0x34BB770", VA = "0x1834BCB70")]
		private void FetchParamFromCmdline()
		{
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x0600CAEB RID: 51947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001803")]
		private string DefaultLuaFilePath
		{
			[Token(Token = "0x600CAEB")]
			[Address(RVA = "0x34BD8F0", Offset = "0x34BC4F0", VA = "0x1834BD8F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CAEC RID: 51948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAEC")]
		[Address(RVA = "0x34BD3A0", Offset = "0x34BBFA0", VA = "0x1834BD3A0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CAED RID: 51949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAED")]
		[Address(RVA = "0x34BCAD0", Offset = "0x34BB6D0", VA = "0x1834BCAD0")]
		public static void DestroyDriver()
		{
		}

		// Token: 0x0600CAEE RID: 51950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAEE")]
		[Address(RVA = "0x34BCDF0", Offset = "0x34BB9F0", VA = "0x1834BCDF0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600CAEF RID: 51951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAEF")]
		[Address(RVA = "0x34BD2F0", Offset = "0x34BBEF0", VA = "0x1834BD2F0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CAF0 RID: 51952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAF0")]
		[Address(RVA = "0x34BD240", Offset = "0x34BBE40", VA = "0x1834BD240")]
		private void OnDisable()
		{
		}

		// Token: 0x0600CAF1 RID: 51953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAF1")]
		[Address(RVA = "0x34BD760", Offset = "0x34BC360", VA = "0x1834BD760")]
		private void _OnSceneLoaded(string from, string to)
		{
		}

		// Token: 0x0600CAF2 RID: 51954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAF2")]
		[Address(RVA = "0x34BCFB0", Offset = "0x34BBBB0", VA = "0x1834BCFB0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600CAF3 RID: 51955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAF3")]
		[Address(RVA = "0x34BD880", Offset = "0x34BC480", VA = "0x1834BD880")]
		public AIRLDriver()
		{
		}

		// Token: 0x0400D4B3 RID: 54451
		[Token(Token = "0x400D4B3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _ip;

		// Token: 0x0400D4B4 RID: 54452
		[Token(Token = "0x400D4B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _port;

		// Token: 0x0400D4B5 RID: 54453
		[Token(Token = "0x400D4B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _luaFilePath;

		// Token: 0x0400D4B6 RID: 54454
		[Token(Token = "0x400D4B6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _readEncrypted;

		// Token: 0x0400D4B7 RID: 54455
		[Token(Token = "0x400D4B7")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _writeEncrypted;

		// Token: 0x0400D4B8 RID: 54456
		[Token(Token = "0x400D4B8")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool _expandOpt;

		// Token: 0x0400D4B9 RID: 54457
		[Token(Token = "0x400D4B9")]
		[FieldOffset(Offset = "0x38")]
		private string m_ip;

		// Token: 0x0400D4BA RID: 54458
		[Token(Token = "0x400D4BA")]
		[FieldOffset(Offset = "0x40")]
		private int m_port;

		// Token: 0x0400D4BB RID: 54459
		[Token(Token = "0x400D4BB")]
		[FieldOffset(Offset = "0x48")]
		private string m_luaFilePath;

		// Token: 0x0400D4BC RID: 54460
		[Token(Token = "0x400D4BC")]
		[FieldOffset(Offset = "0x50")]
		private bool m_readEncrypted;

		// Token: 0x0400D4BD RID: 54461
		[Token(Token = "0x400D4BD")]
		[FieldOffset(Offset = "0x51")]
		private bool m_writeEncrypted;

		// Token: 0x0400D4BE RID: 54462
		[Token(Token = "0x400D4BE")]
		[FieldOffset(Offset = "0x52")]
		private bool m_expandOpt;

		// Token: 0x0400D4BF RID: 54463
		[Token(Token = "0x400D4BF")]
		private const string CMD_ARG_IP = "-ip";

		// Token: 0x0400D4C0 RID: 54464
		[Token(Token = "0x400D4C0")]
		private const string CMD_ARG_PORT = "-port";

		// Token: 0x0400D4C1 RID: 54465
		[Token(Token = "0x400D4C1")]
		private const string CMD_ARG_LUAPATH = "-luapath";

		// Token: 0x0400D4C2 RID: 54466
		[Token(Token = "0x400D4C2")]
		private const string CMD_ARG_READ_ENCRYPTED = "-re";

		// Token: 0x0400D4C3 RID: 54467
		[Token(Token = "0x400D4C3")]
		private const string CMD_ARG_WRITE_ENCRYPTED = "-we";

		// Token: 0x0400D4C4 RID: 54468
		[Token(Token = "0x400D4C4")]
		private const string CMD_ARG_EXPAND_OPT = "-eo";

		// Token: 0x0400D4C5 RID: 54469
		[Token(Token = "0x400D4C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FetchParamFromCmdline;

		// Token: 0x0400D4C6 RID: 54470
		[Token(Token = "0x400D4C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_DefaultLuaFilePath;

		// Token: 0x0400D4C7 RID: 54471
		[Token(Token = "0x400D4C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D4C8 RID: 54472
		[Token(Token = "0x400D4C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DestroyDriver;

		// Token: 0x0400D4C9 RID: 54473
		[Token(Token = "0x400D4C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x0400D4CA RID: 54474
		[Token(Token = "0x400D4CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400D4CB RID: 54475
		[Token(Token = "0x400D4CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400D4CC RID: 54476
		[Token(Token = "0x400D4CC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnSceneLoaded;

		// Token: 0x0400D4CD RID: 54477
		[Token(Token = "0x400D4CD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400D4CE RID: 54478
		[Token(Token = "0x400D4CE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
