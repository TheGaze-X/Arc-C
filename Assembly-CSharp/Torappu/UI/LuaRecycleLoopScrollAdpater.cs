using System;
using Il2CppDummyDll;
using Torappu.Lua;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003988 RID: 14728
	[Token(Token = "0x2003988")]
	public class LuaRecycleLoopScrollAdpater : RecycleLoopScrollAdapter
	{
		// Token: 0x060174AA RID: 95402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174AA")]
		[Address(RVA = "0xFAB6F0", Offset = "0xFAA2F0", VA = "0x180FAB6F0")]
		public void BindLayoutEventListener(LuaRecycleLoopScrollAdpater.ILuaLayoutEvent listener)
		{
		}

		// Token: 0x060174AB RID: 95403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174AB")]
		[Address(RVA = "0xFAB770", Offset = "0xFAA370", VA = "0x180FAB770")]
		public void TraverseCtrlDefines(Action<string, UnityEngine.Object> traverse)
		{
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x060174AC RID: 95404 RVA: 0x00095D78 File Offset: 0x00093F78
		[Token(Token = "0x170037C2")]
		public override int totalCount
		{
			[Token(Token = "0x60174AC")]
			[Address(RVA = "0xFABC00", Offset = "0xFAA800", VA = "0x180FABC00", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060174AD RID: 95405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174AD")]
		[Address(RVA = "0xFAB860", Offset = "0xFAA460", VA = "0x180FAB860", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x060174AE RID: 95406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60174AE")]
		[Address(RVA = "0xFAB9A0", Offset = "0xFAA5A0", VA = "0x180FAB9A0", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x060174AF RID: 95407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174AF")]
		[Address(RVA = "0xFABAD0", Offset = "0xFAA6D0", VA = "0x180FABAD0")]
		public LuaRecycleLoopScrollAdpater()
		{
		}

		// Token: 0x0401C1E4 RID: 115172
		[Token(Token = "0x401C1E4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ControllerDefine[] _ctrlDefines;

		// Token: 0x0401C1E5 RID: 115173
		[Token(Token = "0x401C1E5")]
		[FieldOffset(Offset = "0x60")]
		private LuaRecycleLoopScrollAdpater.ILuaLayoutEvent m_event;

		// Token: 0x0401C1E6 RID: 115174
		[Token(Token = "0x401C1E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BindLayoutEventListener;

		// Token: 0x0401C1E7 RID: 115175
		[Token(Token = "0x401C1E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TraverseCtrlDefines;

		// Token: 0x0401C1E8 RID: 115176
		[Token(Token = "0x401C1E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x0401C1E9 RID: 115177
		[Token(Token = "0x401C1E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401C1EA RID: 115178
		[Token(Token = "0x401C1EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0401C1EB RID: 115179
		[Token(Token = "0x401C1EB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003989 RID: 14729
		[Token(Token = "0x2003989")]
		[CSharpCallLua]
		public interface ILuaLayoutEvent
		{
			// Token: 0x060174B0 RID: 95408
			[Token(Token = "0x60174B0")]
			void OnRender(Transform transform, int index);

			// Token: 0x060174B1 RID: 95409
			[Token(Token = "0x60174B1")]
			int GetTotalCount();

			// Token: 0x060174B2 RID: 95410
			[Token(Token = "0x60174B2")]
			GameObject ViewConstructor(GameObjectPool objectPool);
		}
	}
}
