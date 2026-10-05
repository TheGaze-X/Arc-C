using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SocketNetwork.SvrCom
{
	// Token: 0x020014B1 RID: 5297
	[Token(Token = "0x20014B1")]
	public abstract class ServiceCoreBase<TService> : ServiceDriveBase where TService : ServiceCoreBase<TService>
	{
		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06007A42 RID: 31298 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A43 RID: 31299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E94")]
		private protected static TService s_instance
		{
			[Token(Token = "0x6007A42")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6007A43")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06007A44 RID: 31300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E95")]
		public static TService status
		{
			[Token(Token = "0x6007A44")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06007A45 RID: 31301 RVA: 0x00036C00 File Offset: 0x00034E00
		[Token(Token = "0x17000E96")]
		public static bool started
		{
			[Token(Token = "0x6007A45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A46")]
		public static void Stop()
		{
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007A47")]
		protected static TService _Setup()
		{
			return null;
		}

		// Token: 0x06007A48 RID: 31304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007A48")]
		private static TService _CreateInstance()
		{
			return null;
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A49")]
		protected ServiceCoreBase()
		{
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4A")]
		public void Dispose()
		{
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4B")]
		protected sealed override void OnQuit()
		{
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4C")]
		private void _HandleSceneChanged(string from, string to)
		{
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4D")]
		protected virtual void OnDispose()
		{
		}

		// Token: 0x0400785E RID: 30814
		[Token(Token = "0x400785E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_s_instance;

		// Token: 0x0400785F RID: 30815
		[Token(Token = "0x400785F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_s_instance;

		// Token: 0x04007860 RID: 30816
		[Token(Token = "0x4007860")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x04007861 RID: 30817
		[Token(Token = "0x4007861")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_started;

		// Token: 0x04007862 RID: 30818
		[Token(Token = "0x4007862")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x04007863 RID: 30819
		[Token(Token = "0x4007863")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Setup;

		// Token: 0x04007864 RID: 30820
		[Token(Token = "0x4007864")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CreateInstance;

		// Token: 0x04007865 RID: 30821
		[Token(Token = "0x4007865")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007866 RID: 30822
		[Token(Token = "0x4007866")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04007867 RID: 30823
		[Token(Token = "0x4007867")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnQuit;

		// Token: 0x04007868 RID: 30824
		[Token(Token = "0x4007868")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleSceneChanged;

		// Token: 0x04007869 RID: 30825
		[Token(Token = "0x4007869")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDispose;
	}
}
