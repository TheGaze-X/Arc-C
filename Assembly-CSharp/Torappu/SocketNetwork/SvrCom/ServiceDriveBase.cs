using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SocketNetwork.SvrCom
{
	// Token: 0x020014B2 RID: 5298
	[Token(Token = "0x20014B2")]
	public abstract class ServiceDriveBase : IHotfixable
	{
		// Token: 0x06007A4E RID: 31310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4E")]
		[Address(RVA = "0x264B4D0", Offset = "0x264A0D0", VA = "0x18264B4D0")]
		protected static void AddToDrive(ServiceDriveBase inst)
		{
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A4F")]
		[Address(RVA = "0x264B780", Offset = "0x264A380", VA = "0x18264B780")]
		protected static void RemoveFromDrive(ServiceDriveBase inst)
		{
		}

		// Token: 0x06007A50 RID: 31312
		[Token(Token = "0x6007A50")]
		protected abstract void OnQuit();

		// Token: 0x06007A51 RID: 31313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A51")]
		[Address(RVA = "0x264B9D0", Offset = "0x264A5D0", VA = "0x18264B9D0")]
		private void _Update()
		{
		}

		// Token: 0x06007A52 RID: 31314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A52")]
		[Address(RVA = "0x264B8D0", Offset = "0x264A4D0", VA = "0x18264B8D0")]
		private void _FixedUpdate()
		{
		}

		// Token: 0x06007A53 RID: 31315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A53")]
		[Address(RVA = "0x264B950", Offset = "0x264A550", VA = "0x18264B950")]
		private void _OnGUI()
		{
		}

		// Token: 0x06007A54 RID: 31316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A54")]
		[Address(RVA = "0x264B720", Offset = "0x264A320", VA = "0x18264B720", Slot = "5")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A55")]
		[Address(RVA = "0x264B660", Offset = "0x264A260", VA = "0x18264B660", Slot = "6")]
		protected virtual void OnFixedUpdate()
		{
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A56")]
		[Address(RVA = "0x264B6C0", Offset = "0x264A2C0", VA = "0x18264B6C0", Slot = "7")]
		protected virtual void OnGUI()
		{
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A57")]
		[Address(RVA = "0x264BA50", Offset = "0x264A650", VA = "0x18264BA50")]
		protected ServiceDriveBase()
		{
		}

		// Token: 0x0400786A RID: 30826
		[Token(Token = "0x400786A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AddToDrive;

		// Token: 0x0400786B RID: 30827
		[Token(Token = "0x400786B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RemoveFromDrive;

		// Token: 0x0400786C RID: 30828
		[Token(Token = "0x400786C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Update;

		// Token: 0x0400786D RID: 30829
		[Token(Token = "0x400786D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FixedUpdate;

		// Token: 0x0400786E RID: 30830
		[Token(Token = "0x400786E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnGUI;

		// Token: 0x0400786F RID: 30831
		[Token(Token = "0x400786F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04007870 RID: 30832
		[Token(Token = "0x4007870")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x04007871 RID: 30833
		[Token(Token = "0x4007871")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnGUI;

		// Token: 0x04007872 RID: 30834
		[Token(Token = "0x4007872")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020014B3 RID: 5299
		[Token(Token = "0x20014B3")]
		private class ServiceDriver : SingletonMonoBehaviour<ServiceDriveBase.ServiceDriver>
		{
			// Token: 0x17000E97 RID: 3735
			// (get) Token: 0x06007A58 RID: 31320 RVA: 0x00036C18 File Offset: 0x00034E18
			[Token(Token = "0x17000E97")]
			private bool nothingToDo
			{
				[Token(Token = "0x6007A58")]
				[Address(RVA = "0x264C390", Offset = "0x264AF90", VA = "0x18264C390")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007A59 RID: 31321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A59")]
			[Address(RVA = "0x264BE40", Offset = "0x264AA40", VA = "0x18264BE40", Slot = "4")]
			protected override void OnInit()
			{
			}

			// Token: 0x06007A5A RID: 31322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A5A")]
			[Address(RVA = "0x264BFF0", Offset = "0x264ABF0", VA = "0x18264BFF0")]
			private void Update()
			{
			}

			// Token: 0x06007A5B RID: 31323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A5B")]
			[Address(RVA = "0x264BC10", Offset = "0x264A810", VA = "0x18264BC10")]
			private void FixedUpdate()
			{
			}

			// Token: 0x06007A5C RID: 31324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A5C")]
			[Address(RVA = "0x264BD60", Offset = "0x264A960", VA = "0x18264BD60")]
			private void OnApplicationQuit()
			{
			}

			// Token: 0x06007A5D RID: 31325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A5D")]
			[Address(RVA = "0x264BDC0", Offset = "0x264A9C0", VA = "0x18264BDC0", Slot = "7")]
			protected override void OnDestroy()
			{
			}

			// Token: 0x06007A5E RID: 31326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A5E")]
			[Address(RVA = "0x264C140", Offset = "0x264AD40", VA = "0x18264C140")]
			private void _NotifyQuit()
			{
			}

			// Token: 0x06007A5F RID: 31327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A5F")]
			[Address(RVA = "0x264BED0", Offset = "0x264AAD0", VA = "0x18264BED0")]
			public static void RemoveService(ServiceDriveBase service)
			{
			}

			// Token: 0x06007A60 RID: 31328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A60")]
			[Address(RVA = "0x264BAB0", Offset = "0x264A6B0", VA = "0x18264BAB0")]
			public static void AddService(ServiceDriveBase service)
			{
			}

			// Token: 0x06007A61 RID: 31329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A61")]
			[Address(RVA = "0x264C320", Offset = "0x264AF20", VA = "0x18264C320")]
			public ServiceDriver()
			{
			}

			// Token: 0x04007873 RID: 30835
			[Token(Token = "0x4007873")]
			[FieldOffset(Offset = "0x18")]
			private List<ServiceDriveBase> m_serviceList;

			// Token: 0x04007874 RID: 30836
			[Token(Token = "0x4007874")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_nothingToDo;

			// Token: 0x04007875 RID: 30837
			[Token(Token = "0x4007875")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04007876 RID: 30838
			[Token(Token = "0x4007876")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Update;

			// Token: 0x04007877 RID: 30839
			[Token(Token = "0x4007877")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_FixedUpdate;

			// Token: 0x04007878 RID: 30840
			[Token(Token = "0x4007878")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnApplicationQuit;

			// Token: 0x04007879 RID: 30841
			[Token(Token = "0x4007879")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnDestroy;

			// Token: 0x0400787A RID: 30842
			[Token(Token = "0x400787A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__NotifyQuit;

			// Token: 0x0400787B RID: 30843
			[Token(Token = "0x400787B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RemoveService;

			// Token: 0x0400787C RID: 30844
			[Token(Token = "0x400787C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_AddService;

			// Token: 0x0400787D RID: 30845
			[Token(Token = "0x400787D")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
