using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Lua;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActFun
{
	// Token: 0x02007142 RID: 28994
	[Token(Token = "0x2007142")]
	public class ActFunBattleFinishView : ActivityBattleFinishView, IContextHost
	{
		// Token: 0x0602928E RID: 168590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602928E")]
		[Address(RVA = "0x248EB80", Offset = "0x248D780", VA = "0x18248EB80", Slot = "11")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602928F RID: 168591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602928F")]
		[Address(RVA = "0x248EE70", Offset = "0x248DA70", VA = "0x18248EE70", Slot = "10")]
		public override IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x06029290 RID: 168592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029290")]
		[Address(RVA = "0x248ED40", Offset = "0x248D940", VA = "0x18248ED40", Slot = "5")]
		protected override string OverriddenActId(string rawActId, string assetPath)
		{
			return null;
		}

		// Token: 0x06029291 RID: 168593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029291")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06029292 RID: 168594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029292")]
		[Address(RVA = "0x248EFA0", Offset = "0x248DBA0", VA = "0x18248EFA0", Slot = "13")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x06029293 RID: 168595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029293")]
		[Address(RVA = "0x248ECE0", Offset = "0x248D8E0", VA = "0x18248ECE0", Slot = "14")]
		public void OnLeaveContext()
		{
		}

		// Token: 0x06029294 RID: 168596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029294")]
		[Address(RVA = "0x248EB20", Offset = "0x248D720", VA = "0x18248EB20")]
		public void EventOnExitClick()
		{
		}

		// Token: 0x17006171 RID: 24945
		// (get) Token: 0x06029295 RID: 168597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006171")]
		public Transform root
		{
			[Token(Token = "0x6029295")]
			[Address(RVA = "0x248F100", Offset = "0x248DD00", VA = "0x18248F100", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006172 RID: 24946
		// (get) Token: 0x06029296 RID: 168598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006172")]
		public string mainDialog
		{
			[Token(Token = "0x6029296")]
			[Address(RVA = "0x248F0A0", Offset = "0x248DCA0", VA = "0x18248F0A0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029297 RID: 168599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029297")]
		[Address(RVA = "0x248EAC0", Offset = "0x248D6C0", VA = "0x18248EAC0", Slot = "17")]
		public IDictionary<string, Type> CompDeclaration()
		{
			return null;
		}

		// Token: 0x06029298 RID: 168600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029298")]
		[Address(RVA = "0x248EF40", Offset = "0x248DB40", VA = "0x18248EF40", Slot = "18")]
		public UnityEngine.Object UICompDialogHost()
		{
			return null;
		}

		// Token: 0x06029299 RID: 168601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029299")]
		[Address(RVA = "0x248F040", Offset = "0x248DC40", VA = "0x18248F040")]
		public ActFunBattleFinishView()
		{
		}

		// Token: 0x0602929A RID: 168602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602929A")]
		[Address(RVA = "0x248EF30", Offset = "0x248DB30", VA = "0x18248EF30")]
		private IEnumerator <>xLuaBaseProxy_ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0602929B RID: 168603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602929B")]
		[Address(RVA = "0x248EF20", Offset = "0x248DB20", VA = "0x18248EF20")]
		private string <>xLuaBaseProxy_OverriddenActId(string P0, string P1)
		{
			return null;
		}

		// Token: 0x0403AC85 RID: 240773
		[Token(Token = "0x403AC85")]
		private const string ACTID_ACTFUN = "actfun";

		// Token: 0x0403AC86 RID: 240774
		[Token(Token = "0x403AC86")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _mainDialog;

		// Token: 0x0403AC87 RID: 240775
		[Token(Token = "0x403AC87")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _dlgRoot;

		// Token: 0x0403AC88 RID: 240776
		[Token(Token = "0x403AC88")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _actfunActId;

		// Token: 0x0403AC89 RID: 240777
		[Token(Token = "0x403AC89")]
		[FieldOffset(Offset = "0x48")]
		private LuaUIContext m_context;

		// Token: 0x0403AC8A RID: 240778
		[Token(Token = "0x403AC8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403AC8B RID: 240779
		[Token(Token = "0x403AC8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x0403AC8C RID: 240780
		[Token(Token = "0x403AC8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OverriddenActId;

		// Token: 0x0403AC8D RID: 240781
		[Token(Token = "0x403AC8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0403AC8E RID: 240782
		[Token(Token = "0x403AC8E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x0403AC8F RID: 240783
		[Token(Token = "0x403AC8F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnLeaveContext;

		// Token: 0x0403AC90 RID: 240784
		[Token(Token = "0x403AC90")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnExitClick;

		// Token: 0x0403AC91 RID: 240785
		[Token(Token = "0x403AC91")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_root;

		// Token: 0x0403AC92 RID: 240786
		[Token(Token = "0x403AC92")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_mainDialog;

		// Token: 0x0403AC93 RID: 240787
		[Token(Token = "0x403AC93")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CompDeclaration;

		// Token: 0x0403AC94 RID: 240788
		[Token(Token = "0x403AC94")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UICompDialogHost;

		// Token: 0x0403AC95 RID: 240789
		[Token(Token = "0x403AC95")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
