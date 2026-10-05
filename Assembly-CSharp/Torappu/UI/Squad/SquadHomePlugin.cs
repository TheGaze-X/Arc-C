using System;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E2E RID: 15918
	[Token(Token = "0x2003E2E")]
	public class SquadHomePlugin : IHotfixable, IDisposable
	{
		// Token: 0x06018BD6 RID: 101334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BD6")]
		[Address(RVA = "0x1142650", Offset = "0x1141250", VA = "0x181142650")]
		public SquadHomePlugin(SquadHomePlugin.PluginInputParams param, SquadHomePluginView view)
		{
		}

		// Token: 0x06018BD7 RID: 101335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BD7")]
		[Address(RVA = "0x1141EE0", Offset = "0x1140AE0", VA = "0x181141EE0")]
		public void BindGroupController(SquadHomePlugin.GroupControllerBindings bindings)
		{
		}

		// Token: 0x06018BD8 RID: 101336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BD8")]
		[Address(RVA = "0x1142440", Offset = "0x1141040", VA = "0x181142440")]
		public void OnSquadHomeStateEnter()
		{
		}

		// Token: 0x06018BD9 RID: 101337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BD9")]
		[Address(RVA = "0x1142500", Offset = "0x1141100", VA = "0x181142500")]
		public void OnSquadHomeStateResume()
		{
		}

		// Token: 0x06018BDA RID: 101338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BDA")]
		[Address(RVA = "0x11423E0", Offset = "0x1140FE0", VA = "0x1811423E0")]
		public void OnPluginLoad()
		{
		}

		// Token: 0x06018BDB RID: 101339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018BDB")]
		[Address(RVA = "0x1142340", Offset = "0x1140F40", VA = "0x181142340")]
		public SquadHomeStartBattleServicePluginBase GetStartBattleServicePlugin()
		{
			return null;
		}

		// Token: 0x06018BDC RID: 101340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018BDC")]
		[Address(RVA = "0x11421A0", Offset = "0x1140DA0", VA = "0x1811421A0")]
		public SquadHomeFinishBattleServicePluginBase GetFinishBattleServicePlugin()
		{
			return null;
		}

		// Token: 0x06018BDD RID: 101341 RVA: 0x0009B880 File Offset: 0x00099A80
		[Token(Token = "0x6018BDD")]
		[Address(RVA = "0x1142240", Offset = "0x1140E40", VA = "0x181142240")]
		public BattleActivityMeta GetOverrideActMeta(string activityId)
		{
			return default(BattleActivityMeta);
		}

		// Token: 0x06018BDE RID: 101342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BDE")]
		[Address(RVA = "0x1142090", Offset = "0x1140C90", VA = "0x181142090", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06018BDF RID: 101343 RVA: 0x0009B898 File Offset: 0x00099A98
		[Token(Token = "0x6018BDF")]
		[Address(RVA = "0x11425C0", Offset = "0x11411C0", VA = "0x1811425C0")]
		private bool _CheckIfDisposed()
		{
			return default(bool);
		}

		// Token: 0x0401E647 RID: 124487
		[Token(Token = "0x401E647")]
		[FieldOffset(Offset = "0x10")]
		private SquadHomePlugin.PluginInputParams m_param;

		// Token: 0x0401E648 RID: 124488
		[Token(Token = "0x401E648")]
		[FieldOffset(Offset = "0x20")]
		private SquadHomePluginView m_view;

		// Token: 0x0401E649 RID: 124489
		[Token(Token = "0x401E649")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401E64A RID: 124490
		[Token(Token = "0x401E64A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BindGroupController;

		// Token: 0x0401E64B RID: 124491
		[Token(Token = "0x401E64B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSquadHomeStateEnter;

		// Token: 0x0401E64C RID: 124492
		[Token(Token = "0x401E64C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSquadHomeStateResume;

		// Token: 0x0401E64D RID: 124493
		[Token(Token = "0x401E64D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPluginLoad;

		// Token: 0x0401E64E RID: 124494
		[Token(Token = "0x401E64E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetStartBattleServicePlugin;

		// Token: 0x0401E64F RID: 124495
		[Token(Token = "0x401E64F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetFinishBattleServicePlugin;

		// Token: 0x0401E650 RID: 124496
		[Token(Token = "0x401E650")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetOverrideActMeta;

		// Token: 0x0401E651 RID: 124497
		[Token(Token = "0x401E651")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401E652 RID: 124498
		[Token(Token = "0x401E652")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckIfDisposed;

		// Token: 0x02003E2F RID: 15919
		[Token(Token = "0x2003E2F")]
		public struct PluginInputParams
		{
			// Token: 0x0401E653 RID: 124499
			[Token(Token = "0x401E653")]
			[FieldOffset(Offset = "0x0")]
			public string stageId;

			// Token: 0x0401E654 RID: 124500
			[Token(Token = "0x401E654")]
			[FieldOffset(Offset = "0x8")]
			public bool isAutoMode;

			// Token: 0x0401E655 RID: 124501
			[Token(Token = "0x401E655")]
			[FieldOffset(Offset = "0x9")]
			public bool isRetro;

			// Token: 0x0401E656 RID: 124502
			[Token(Token = "0x401E656")]
			[FieldOffset(Offset = "0xA")]
			public bool blockLoad;

			// Token: 0x0401E657 RID: 124503
			[Token(Token = "0x401E657")]
			[FieldOffset(Offset = "0x0")]
			public static SquadHomePlugin.PluginInputParams DEFAULT;
		}

		// Token: 0x02003E30 RID: 15920
		[Token(Token = "0x2003E30")]
		public class GroupControllerBindings : IHotfixable
		{
			// Token: 0x06018BE1 RID: 101345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018BE1")]
			[Address(RVA = "0x1135C00", Offset = "0x1134800", VA = "0x181135C00")]
			private GroupControllerBindings()
			{
			}

			// Token: 0x06018BE2 RID: 101346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018BE2")]
			[Address(RVA = "0x1135B80", Offset = "0x1134780", VA = "0x181135B80")]
			public void SetShowLeftArrow(bool show)
			{
			}

			// Token: 0x0401E658 RID: 124504
			[Token(Token = "0x401E658")]
			[FieldOffset(Offset = "0x10")]
			private Action<bool> m_callShowLeftArrow;

			// Token: 0x0401E659 RID: 124505
			[Token(Token = "0x401E659")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E65A RID: 124506
			[Token(Token = "0x401E65A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetShowLeftArrow;

			// Token: 0x02003E31 RID: 15921
			[Token(Token = "0x2003E31")]
			public struct Builder
			{
				// Token: 0x06018BE3 RID: 101347 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6018BE3")]
				[Address(RVA = "0x11356F0", Offset = "0x11342F0", VA = "0x1811356F0")]
				public SquadHomePlugin.GroupControllerBindings Build()
				{
					return null;
				}

				// Token: 0x0401E65B RID: 124507
				[Token(Token = "0x401E65B")]
				[FieldOffset(Offset = "0x0")]
				public Action<bool> showLeftArrow;
			}
		}
	}
}
