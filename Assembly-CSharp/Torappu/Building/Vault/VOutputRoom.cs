using System;
using AdvancedInspector;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A4F RID: 6735
	[Token(Token = "0x2001A4F")]
	public class VOutputRoom : VRoom
	{
		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x0600A902 RID: 43266 RVA: 0x000417D8 File Offset: 0x0003F9D8
		// (set) Token: 0x0600A903 RID: 43267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013A9")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private protected bool isWorking
		{
			[Token(Token = "0x600A902")]
			[Address(RVA = "0x3245090", Offset = "0x3243C90", VA = "0x183245090")]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x600A903")]
			[Address(RVA = "0x32450F0", Offset = "0x3243CF0", VA = "0x1832450F0")]
			private set
			{
			}
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A904")]
		[Address(RVA = "0x3244BE0", Offset = "0x32437E0", VA = "0x183244BE0", Slot = "8")]
		public override void OnEnter()
		{
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A905")]
		[Address(RVA = "0x3244C50", Offset = "0x3243850", VA = "0x183244C50", Slot = "6")]
		protected override void OnPreInit()
		{
		}

		// Token: 0x0600A906 RID: 43270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A906")]
		[Address(RVA = "0x3244A60", Offset = "0x3243660", VA = "0x183244A60", Slot = "12")]
		protected override void OnDestroyRoom()
		{
		}

		// Token: 0x0600A907 RID: 43271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A907")]
		[Address(RVA = "0x3244B80", Offset = "0x3243780", VA = "0x183244B80")]
		private void OnEnable()
		{
		}

		// Token: 0x0600A908 RID: 43272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A908")]
		[Address(RVA = "0x3244D70", Offset = "0x3243970", VA = "0x183244D70")]
		private void _OnPlayerDataChanged(object _)
		{
		}

		// Token: 0x0600A909 RID: 43273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A909")]
		[Address(RVA = "0x3244F70", Offset = "0x3243B70", VA = "0x183244F70")]
		private void _UpdateIsWorking(bool force)
		{
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A90A")]
		[Address(RVA = "0x3244E20", Offset = "0x3243A20", VA = "0x183244E20")]
		private void _SetIsWorkingInternal(bool value, bool force)
		{
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A90B")]
		[Address(RVA = "0x3245010", Offset = "0x3243C10", VA = "0x183245010")]
		public VOutputRoom()
		{
		}

		// Token: 0x0600A90C RID: 43276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A90C")]
		[Address(RVA = "0x323F7E0", Offset = "0x323E3E0", VA = "0x18323F7E0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600A90D RID: 43277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A90D")]
		[Address(RVA = "0x323F860", Offset = "0x323E460", VA = "0x18323F860")]
		private void <>xLuaBaseProxy_OnPreInit()
		{
		}

		// Token: 0x0600A90E RID: 43278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A90E")]
		[Address(RVA = "0x323F770", Offset = "0x323E370", VA = "0x18323F770")]
		private void <>xLuaBaseProxy_OnDestroyRoom()
		{
		}

		// Token: 0x0400A124 RID: 41252
		[Token(Token = "0x400A124")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isWorking;

		// Token: 0x0400A125 RID: 41253
		[Token(Token = "0x400A125")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isWorking;

		// Token: 0x0400A126 RID: 41254
		[Token(Token = "0x400A126")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isWorking;

		// Token: 0x0400A127 RID: 41255
		[Token(Token = "0x400A127")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400A128 RID: 41256
		[Token(Token = "0x400A128")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPreInit;

		// Token: 0x0400A129 RID: 41257
		[Token(Token = "0x400A129")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroyRoom;

		// Token: 0x0400A12A RID: 41258
		[Token(Token = "0x400A12A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400A12B RID: 41259
		[Token(Token = "0x400A12B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400A12C RID: 41260
		[Token(Token = "0x400A12C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateIsWorking;

		// Token: 0x0400A12D RID: 41261
		[Token(Token = "0x400A12D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetIsWorkingInternal;

		// Token: 0x0400A12E RID: 41262
		[Token(Token = "0x400A12E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
