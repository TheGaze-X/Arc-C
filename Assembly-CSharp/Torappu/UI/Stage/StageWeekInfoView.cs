using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006999 RID: 27033
	[Token(Token = "0x2006999")]
	public class StageWeekInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026ADA RID: 158426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ADA")]
		public void Rebuild<T>(WeekStruct<T> weekConfig, StageWeekInfoView.GetOpenState<T> openState)
		{
		}

		// Token: 0x06026ADB RID: 158427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ADB")]
		[Address(RVA = "0x21BDA50", Offset = "0x21BC650", VA = "0x1821BDA50", Slot = "4")]
		public virtual void InstCheck(ZoneOpenState isActiveFlag)
		{
		}

		// Token: 0x06026ADC RID: 158428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ADC")]
		[Address(RVA = "0x21BDBC0", Offset = "0x21BC7C0", VA = "0x1821BDBC0")]
		public StageWeekInfoView()
		{
		}

		// Token: 0x040369AD RID: 223661
		[Token(Token = "0x40369AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected RectTransform _weekItemContainer;

		// Token: 0x040369AE RID: 223662
		[Token(Token = "0x40369AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected GameObject _inactivePrefab;

		// Token: 0x040369AF RID: 223663
		[Token(Token = "0x40369AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameObject _activePrefab;

		// Token: 0x040369B0 RID: 223664
		[Token(Token = "0x40369B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected GameObject _forceOpenPrefab;

		// Token: 0x040369B1 RID: 223665
		[Token(Token = "0x40369B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Rebuild;

		// Token: 0x040369B2 RID: 223666
		[Token(Token = "0x40369B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InstCheck;

		// Token: 0x040369B3 RID: 223667
		[Token(Token = "0x40369B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200699A RID: 27034
		// (Invoke) Token: 0x06026ADE RID: 158430
		[Token(Token = "0x200699A")]
		public delegate ZoneOpenState GetOpenState<T>(T state);
	}
}
