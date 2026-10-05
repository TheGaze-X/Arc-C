using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003ADF RID: 15071
	[Token(Token = "0x2003ADF")]
	public class UINotificationTasks : Singleton<UINotificationTasks>
	{
		// Token: 0x06017C30 RID: 97328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C30")]
		public static TTask RequestTask<TTask>() where TTask : UINotificationTasks.Task, new()
		{
			return null;
		}

		// Token: 0x06017C31 RID: 97329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C31")]
		[Address(RVA = "0x1010040", Offset = "0x100EC40", VA = "0x181010040")]
		public static UINotificationTasks.DefaultMainUITask RequireMainUITask()
		{
			return null;
		}

		// Token: 0x06017C32 RID: 97330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C32")]
		[Address(RVA = "0x10100D0", Offset = "0x100ECD0", VA = "0x1810100D0")]
		public void UINotifications_Tick()
		{
		}

		// Token: 0x06017C33 RID: 97331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C33")]
		[Address(RVA = "0x1010440", Offset = "0x100F040", VA = "0x181010440")]
		private UINotificationTasks()
		{
		}

		// Token: 0x06017C34 RID: 97332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C34")]
		private TTask _EnsureTask<TTask>() where TTask : UINotificationTasks.Task, new()
		{
			return null;
		}

		// Token: 0x06017C35 RID: 97333 RVA: 0x00097F80 File Offset: 0x00096180
		[Token(Token = "0x6017C35")]
		[Address(RVA = "0x1010320", Offset = "0x100EF20", VA = "0x181010320")]
		private bool _ResetIfUserChanged()
		{
			return default(bool);
		}

		// Token: 0x0401CB1E RID: 117534
		[Token(Token = "0x401CB1E")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<Type, UINotificationTasks.Task> m_activeTasks;

		// Token: 0x0401CB1F RID: 117535
		[Token(Token = "0x401CB1F")]
		[FieldOffset(Offset = "0x18")]
		private string m_uid;

		// Token: 0x0401CB20 RID: 117536
		[Token(Token = "0x401CB20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RequestTask;

		// Token: 0x0401CB21 RID: 117537
		[Token(Token = "0x401CB21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RequireMainUITask;

		// Token: 0x0401CB22 RID: 117538
		[Token(Token = "0x401CB22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UINotifications_Tick;

		// Token: 0x0401CB23 RID: 117539
		[Token(Token = "0x401CB23")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401CB24 RID: 117540
		[Token(Token = "0x401CB24")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureTask;

		// Token: 0x0401CB25 RID: 117541
		[Token(Token = "0x401CB25")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetIfUserChanged;

		// Token: 0x02003AE0 RID: 15072
		[Token(Token = "0x2003AE0")]
		public abstract class Task : IHotfixable
		{
			// Token: 0x06017C36 RID: 97334
			[Token(Token = "0x6017C36")]
			public abstract bool CanConsume();

			// Token: 0x06017C37 RID: 97335
			[Token(Token = "0x6017C37")]
			public abstract void Consume();

			// Token: 0x06017C38 RID: 97336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C38")]
			[Address(RVA = "0x100E2F0", Offset = "0x100CEF0", VA = "0x18100E2F0")]
			protected Task()
			{
			}

			// Token: 0x0401CB26 RID: 117542
			[Token(Token = "0x401CB26")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003AE1 RID: 15073
		[Token(Token = "0x2003AE1")]
		public abstract class MainUITask : UINotificationTasks.Task
		{
			// Token: 0x06017C39 RID: 97337 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017C39")]
			[Address(RVA = "0xFFE310", Offset = "0xFFCF10", VA = "0x180FFE310", Slot = "6")]
			public virtual List<string> GetAvailSceneNames()
			{
				return null;
			}

			// Token: 0x06017C3A RID: 97338 RVA: 0x00097F98 File Offset: 0x00096198
			[Token(Token = "0x6017C3A")]
			[Address(RVA = "0xFFE1D0", Offset = "0xFFCDD0", VA = "0x180FFE1D0")]
			protected bool CheckCommonUITransiting()
			{
				return default(bool);
			}

			// Token: 0x06017C3B RID: 97339 RVA: 0x00097FB0 File Offset: 0x000961B0
			[Token(Token = "0x6017C3B")]
			[Address(RVA = "0xFFE370", Offset = "0xFFCF70", VA = "0x180FFE370", Slot = "7")]
			protected virtual bool IsOnIdleUI(string curScene, List<string> availSceneNames)
			{
				return default(bool);
			}

			// Token: 0x06017C3C RID: 97340 RVA: 0x00097FC8 File Offset: 0x000961C8
			[Token(Token = "0x6017C3C")]
			[Address(RVA = "0xFFE100", Offset = "0xFFCD00", VA = "0x180FFE100", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017C3D RID: 97341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C3D")]
			[Address(RVA = "0xFFE450", Offset = "0xFFD050", VA = "0x180FFE450")]
			protected MainUITask()
			{
			}

			// Token: 0x0401CB27 RID: 117543
			[Token(Token = "0x401CB27")]
			[FieldOffset(Offset = "0x10")]
			private List<string> m_availSceneList;

			// Token: 0x0401CB28 RID: 117544
			[Token(Token = "0x401CB28")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetAvailSceneNames;

			// Token: 0x0401CB29 RID: 117545
			[Token(Token = "0x401CB29")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CheckCommonUITransiting;

			// Token: 0x0401CB2A RID: 117546
			[Token(Token = "0x401CB2A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsOnIdleUI;

			// Token: 0x0401CB2B RID: 117547
			[Token(Token = "0x401CB2B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CB2C RID: 117548
			[Token(Token = "0x401CB2C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003AE2 RID: 15074
		[Token(Token = "0x2003AE2")]
		public abstract class BattleUITask : UINotificationTasks.Task
		{
			// Token: 0x06017C3E RID: 97342 RVA: 0x00097FE0 File Offset: 0x000961E0
			[Token(Token = "0x6017C3E")]
			[Address(RVA = "0xFF9C80", Offset = "0xFF8880", VA = "0x180FF9C80")]
			protected bool CheckCommonUITransiting()
			{
				return default(bool);
			}

			// Token: 0x06017C3F RID: 97343 RVA: 0x00097FF8 File Offset: 0x000961F8
			[Token(Token = "0x6017C3F")]
			[Address(RVA = "0xFF9DB0", Offset = "0xFF89B0", VA = "0x180FF9DB0", Slot = "6")]
			protected virtual bool IsOnBattleUI()
			{
				return default(bool);
			}

			// Token: 0x06017C40 RID: 97344 RVA: 0x00098010 File Offset: 0x00096210
			[Token(Token = "0x6017C40")]
			[Address(RVA = "0xFF9C00", Offset = "0xFF8800", VA = "0x180FF9C00", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017C41 RID: 97345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C41")]
			[Address(RVA = "0xFF9F40", Offset = "0xFF8B40", VA = "0x180FF9F40")]
			protected BattleUITask()
			{
			}

			// Token: 0x0401CB2D RID: 117549
			[Token(Token = "0x401CB2D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckCommonUITransiting;

			// Token: 0x0401CB2E RID: 117550
			[Token(Token = "0x401CB2E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsOnBattleUI;

			// Token: 0x0401CB2F RID: 117551
			[Token(Token = "0x401CB2F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CB30 RID: 117552
			[Token(Token = "0x401CB30")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003AE3 RID: 15075
		[Token(Token = "0x2003AE3")]
		public abstract class UIAndBattleFinishTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017C42 RID: 97346 RVA: 0x00098028 File Offset: 0x00096228
			[Token(Token = "0x6017C42")]
			[Address(RVA = "0x100F180", Offset = "0x100DD80", VA = "0x18100F180")]
			private bool _HandleWithBattle()
			{
				return default(bool);
			}

			// Token: 0x06017C43 RID: 97347 RVA: 0x00098040 File Offset: 0x00096240
			[Token(Token = "0x6017C43")]
			[Address(RVA = "0x100EFC0", Offset = "0x100DBC0", VA = "0x18100EFC0", Slot = "7")]
			protected override bool IsOnIdleUI(string curScene, List<string> availSceneNames)
			{
				return default(bool);
			}

			// Token: 0x06017C44 RID: 97348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C44")]
			[Address(RVA = "0x100F260", Offset = "0x100DE60", VA = "0x18100F260")]
			protected UIAndBattleFinishTask()
			{
			}

			// Token: 0x06017C45 RID: 97349 RVA: 0x00098058 File Offset: 0x00096258
			[Token(Token = "0x6017C45")]
			[Address(RVA = "0x100F170", Offset = "0x100DD70", VA = "0x18100F170")]
			private bool <>xLuaBaseProxy_IsOnIdleUI(string P0, List<string> P1)
			{
				return default(bool);
			}

			// Token: 0x0401CB31 RID: 117553
			[Token(Token = "0x401CB31")]
			[FieldOffset(Offset = "0x18")]
			private bool m_isBattleAvail;

			// Token: 0x0401CB32 RID: 117554
			[Token(Token = "0x401CB32")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__HandleWithBattle;

			// Token: 0x0401CB33 RID: 117555
			[Token(Token = "0x401CB33")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsOnIdleUI;

			// Token: 0x0401CB34 RID: 117556
			[Token(Token = "0x401CB34")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003AE4 RID: 15076
		[Token(Token = "0x2003AE4")]
		public abstract class StagePageUITask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017C46 RID: 97350 RVA: 0x00098070 File Offset: 0x00096270
			[Token(Token = "0x6017C46")]
			[Address(RVA = "0x100E1F0", Offset = "0x100CDF0", VA = "0x18100E1F0")]
			protected bool IsOnStagePageUI()
			{
				return default(bool);
			}

			// Token: 0x06017C47 RID: 97351 RVA: 0x00098088 File Offset: 0x00096288
			[Token(Token = "0x6017C47")]
			[Address(RVA = "0x100E120", Offset = "0x100CD20", VA = "0x18100E120", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017C48 RID: 97352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C48")]
			[Address(RVA = "0x100E290", Offset = "0x100CE90", VA = "0x18100E290")]
			protected StagePageUITask()
			{
			}

			// Token: 0x06017C49 RID: 97353 RVA: 0x000980A0 File Offset: 0x000962A0
			[Token(Token = "0x6017C49")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0401CB35 RID: 117557
			[Token(Token = "0x401CB35")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsOnStagePageUI;

			// Token: 0x0401CB36 RID: 117558
			[Token(Token = "0x401CB36")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CB37 RID: 117559
			[Token(Token = "0x401CB37")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003AE5 RID: 15077
		[Token(Token = "0x2003AE5")]
		public sealed class DefaultMainUITask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017C4A RID: 97354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C4A")]
			[Address(RVA = "0xFF9FE0", Offset = "0xFF8BE0", VA = "0x180FF9FE0")]
			public void AddCall(UINotificationTasks.DefaultMainUITask.ICall call)
			{
			}

			// Token: 0x06017C4B RID: 97355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C4B")]
			[Address(RVA = "0xFFA080", Offset = "0xFF8C80", VA = "0x180FFA080", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017C4C RID: 97356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C4C")]
			[Address(RVA = "0xFFA290", Offset = "0xFF8E90", VA = "0x180FFA290")]
			public DefaultMainUITask()
			{
			}

			// Token: 0x0401CB38 RID: 117560
			[Token(Token = "0x401CB38")]
			[FieldOffset(Offset = "0x18")]
			private List<UINotificationTasks.DefaultMainUITask.ICall> m_calls;

			// Token: 0x0401CB39 RID: 117561
			[Token(Token = "0x401CB39")]
			[FieldOffset(Offset = "0x20")]
			private bool m_lock;

			// Token: 0x0401CB3A RID: 117562
			[Token(Token = "0x401CB3A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_AddCall;

			// Token: 0x0401CB3B RID: 117563
			[Token(Token = "0x401CB3B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CB3C RID: 117564
			[Token(Token = "0x401CB3C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02003AE6 RID: 15078
			[Token(Token = "0x2003AE6")]
			public interface ICall
			{
				// Token: 0x06017C4D RID: 97357
				[Token(Token = "0x6017C4D")]
				void Call();
			}
		}
	}
}
