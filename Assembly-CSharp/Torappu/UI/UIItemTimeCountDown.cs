using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200373C RID: 14140
	[Token(Token = "0x200373C")]
	public class UIItemTimeCountDown : MonoBehaviour, ITimeWatcher, IHotfixable
	{
		// Token: 0x0601675F RID: 91999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601675F")]
		[Address(RVA = "0xEEBBB0", Offset = "0xEEA7B0", VA = "0x180EEBBB0")]
		public void SetScaler(float scale)
		{
		}

		// Token: 0x06016760 RID: 92000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016760")]
		[Address(RVA = "0xEEBDD0", Offset = "0xEEA9D0", VA = "0x180EEBDD0")]
		private void _OnValidTimeTick(CountDownTask.TickValue tick)
		{
		}

		// Token: 0x06016761 RID: 92001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016761")]
		[Address(RVA = "0xEEB680", Offset = "0xEEA280", VA = "0x180EEB680")]
		public void ApplyCountDown(Action onTimeOut, long remainSecs)
		{
		}

		// Token: 0x06016762 RID: 92002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016762")]
		[Address(RVA = "0xEEB8B0", Offset = "0xEEA4B0", VA = "0x180EEB8B0")]
		public void CleanCountDown()
		{
		}

		// Token: 0x06016763 RID: 92003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016763")]
		[Address(RVA = "0xEEBB50", Offset = "0xEEA750", VA = "0x180EEBB50")]
		public void RegisterCountDown()
		{
		}

		// Token: 0x06016764 RID: 92004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016764")]
		[Address(RVA = "0xEEBC80", Offset = "0xEEA880", VA = "0x180EEBC80")]
		public void UnRegisterCountDown()
		{
		}

		// Token: 0x06016765 RID: 92005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016765")]
		[Address(RVA = "0xEEBED0", Offset = "0xEEAAD0", VA = "0x180EEBED0")]
		private void _UpdateValidTimeStyle(ItemValidTimeLevel level)
		{
		}

		// Token: 0x06016766 RID: 92006 RVA: 0x00091500 File Offset: 0x0008F700
		[Token(Token = "0x6016766")]
		[Address(RVA = "0xEEBD60", Offset = "0xEEA960", VA = "0x180EEBD60")]
		private bool _IsOverrideTimeStyleEmpty()
		{
			return default(bool);
		}

		// Token: 0x06016767 RID: 92007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016767")]
		[Address(RVA = "0xEEB9A0", Offset = "0xEEA5A0", VA = "0x180EEB9A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016768 RID: 92008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016768")]
		[Address(RVA = "0xEEBCE0", Offset = "0xEEA8E0", VA = "0x180EEBCE0", Slot = "4")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x06016769 RID: 92009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016769")]
		[Address(RVA = "0xEEBA00", Offset = "0xEEA600", VA = "0x180EEBA00")]
		public void OverrideStyleConfig(Color bkgColor, Color iconColor, Color textColor)
		{
		}

		// Token: 0x0601676A RID: 92010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601676A")]
		[Address(RVA = "0xEEB920", Offset = "0xEEA520", VA = "0x180EEB920")]
		public void ClearOverrideStyle()
		{
		}

		// Token: 0x0601676B RID: 92011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601676B")]
		[Address(RVA = "0xEEC110", Offset = "0xEEAD10", VA = "0x180EEC110")]
		public UIItemTimeCountDown()
		{
		}

		// Token: 0x0401B0BB RID: 110779
		[Token(Token = "0x401B0BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Time")]
		private UIItemTimeCountDown.TimeStyleConfig _timeStyleEmer;

		// Token: 0x0401B0BC RID: 110780
		[Token(Token = "0x401B0BC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Time")]
		private UIItemTimeCountDown.TimeStyleConfig _timeStyleWarn;

		// Token: 0x0401B0BD RID: 110781
		[Token(Token = "0x401B0BD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Time")]
		private UIItemTimeCountDown.TimeStyleConfig _timeStyleSafe;

		// Token: 0x0401B0BE RID: 110782
		[Token(Token = "0x401B0BE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Time")]
		private Image _imgTimeBkg;

		// Token: 0x0401B0BF RID: 110783
		[Token(Token = "0x401B0BF")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Time")]
		private Image _imgTimeIcon;

		// Token: 0x0401B0C0 RID: 110784
		[Token(Token = "0x401B0C0")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Time")]
		private Text _textTime;

		// Token: 0x0401B0C1 RID: 110785
		[Token(Token = "0x401B0C1")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Time")]
		private GameObject _panelTime;

		// Token: 0x0401B0C2 RID: 110786
		[Token(Token = "0x401B0C2")]
		[FieldOffset(Offset = "0xC8")]
		private CountDownTask m_validTimeTask;

		// Token: 0x0401B0C3 RID: 110787
		[Token(Token = "0x401B0C3")]
		[FieldOffset(Offset = "0xD0")]
		private ItemValidTimeLevel m_validTimeLevel;

		// Token: 0x0401B0C4 RID: 110788
		[Token(Token = "0x401B0C4")]
		[FieldOffset(Offset = "0xD4")]
		private UIItemTimeCountDown.TimeStyleConfig? m_overrideTimeStyle;

		// Token: 0x0401B0C5 RID: 110789
		[Token(Token = "0x401B0C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetScaler;

		// Token: 0x0401B0C6 RID: 110790
		[Token(Token = "0x401B0C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnValidTimeTick;

		// Token: 0x0401B0C7 RID: 110791
		[Token(Token = "0x401B0C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyCountDown;

		// Token: 0x0401B0C8 RID: 110792
		[Token(Token = "0x401B0C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CleanCountDown;

		// Token: 0x0401B0C9 RID: 110793
		[Token(Token = "0x401B0C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterCountDown;

		// Token: 0x0401B0CA RID: 110794
		[Token(Token = "0x401B0CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UnRegisterCountDown;

		// Token: 0x0401B0CB RID: 110795
		[Token(Token = "0x401B0CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateValidTimeStyle;

		// Token: 0x0401B0CC RID: 110796
		[Token(Token = "0x401B0CC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__IsOverrideTimeStyleEmpty;

		// Token: 0x0401B0CD RID: 110797
		[Token(Token = "0x401B0CD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B0CE RID: 110798
		[Token(Token = "0x401B0CE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0401B0CF RID: 110799
		[Token(Token = "0x401B0CF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OverrideStyleConfig;

		// Token: 0x0401B0D0 RID: 110800
		[Token(Token = "0x401B0D0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ClearOverrideStyle;

		// Token: 0x0401B0D1 RID: 110801
		[Token(Token = "0x401B0D1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200373D RID: 14141
		[Token(Token = "0x200373D")]
		[Serializable]
		private struct TimeStyleConfig
		{
			// Token: 0x0401B0D2 RID: 110802
			[Token(Token = "0x401B0D2")]
			[FieldOffset(Offset = "0x0")]
			public Color bkg;

			// Token: 0x0401B0D3 RID: 110803
			[Token(Token = "0x401B0D3")]
			[FieldOffset(Offset = "0x10")]
			public Color icon;

			// Token: 0x0401B0D4 RID: 110804
			[Token(Token = "0x401B0D4")]
			[FieldOffset(Offset = "0x20")]
			public Color text;
		}
	}
}
