using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004884 RID: 18564
	[Token(Token = "0x2004884")]
	public class DailyMissionRewardTask : MonoBehaviour, IHotfixable, IAsyncDataView<DailyMissionRewardTask.Data>, IAsyncShowEffect
	{
		// Token: 0x0601C071 RID: 114801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C071")]
		[Address(RVA = "0x15635C0", Offset = "0x15621C0", VA = "0x1815635C0")]
		private void _SetFinished(bool finish)
		{
		}

		// Token: 0x17004299 RID: 17049
		// (get) Token: 0x0601C072 RID: 114802 RVA: 0x000A6F68 File Offset: 0x000A5168
		[Token(Token = "0x17004299")]
		public int serialNumber
		{
			[Token(Token = "0x601C072")]
			[Address(RVA = "0x15637C0", Offset = "0x15623C0", VA = "0x1815637C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700429A RID: 17050
		// (get) Token: 0x0601C073 RID: 114803 RVA: 0x000A6F80 File Offset: 0x000A5180
		[Token(Token = "0x1700429A")]
		public int rewardState
		{
			[Token(Token = "0x601C073")]
			[Address(RVA = "0x1563760", Offset = "0x1562360", VA = "0x181563760")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601C074 RID: 114804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C074")]
		[Address(RVA = "0x1563520", Offset = "0x1562120", VA = "0x181563520", Slot = "5")]
		public void AsyncShow()
		{
		}

		// Token: 0x0601C075 RID: 114805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C075")]
		[Address(RVA = "0x1562F60", Offset = "0x1561B60", VA = "0x181562F60", Slot = "4")]
		public void AsyncSetData(DailyMissionRewardTask.Data dataWrapper)
		{
		}

		// Token: 0x0601C076 RID: 114806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C076")]
		[Address(RVA = "0x15636F0", Offset = "0x15622F0", VA = "0x1815636F0")]
		public DailyMissionRewardTask()
		{
		}

		// Token: 0x04024914 RID: 149780
		[Token(Token = "0x4024914")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MissionRewardPreviewItem _item1;

		// Token: 0x04024915 RID: 149781
		[Token(Token = "0x4024915")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MissionRewardPreviewItem _item2;

		// Token: 0x04024916 RID: 149782
		[Token(Token = "0x4024916")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DailyMissionRewardPoint[] _points;

		// Token: 0x04024917 RID: 149783
		[Token(Token = "0x4024917")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _finished;

		// Token: 0x04024918 RID: 149784
		[Token(Token = "0x4024918")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04024919 RID: 149785
		[Token(Token = "0x4024919")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _completeAlpha;

		// Token: 0x0402491A RID: 149786
		[Token(Token = "0x402491A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _serialNumberLabel;

		// Token: 0x0402491B RID: 149787
		[Token(Token = "0x402491B")]
		[FieldOffset(Offset = "0x50")]
		private string m_dataCacheId;

		// Token: 0x0402491C RID: 149788
		[Token(Token = "0x402491C")]
		[FieldOffset(Offset = "0x58")]
		private MissionType m_dataCacheIdType;

		// Token: 0x0402491D RID: 149789
		[Token(Token = "0x402491D")]
		[FieldOffset(Offset = "0x5C")]
		private int m_serialNumber;

		// Token: 0x0402491E RID: 149790
		[Token(Token = "0x402491E")]
		[FieldOffset(Offset = "0x60")]
		private int m_rewardState;

		// Token: 0x0402491F RID: 149791
		[Token(Token = "0x402491F")]
		[FieldOffset(Offset = "0x64")]
		private bool m_isFinish;

		// Token: 0x04024920 RID: 149792
		[Token(Token = "0x4024920")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetFinished;

		// Token: 0x04024921 RID: 149793
		[Token(Token = "0x4024921")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serialNumber;

		// Token: 0x04024922 RID: 149794
		[Token(Token = "0x4024922")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rewardState;

		// Token: 0x04024923 RID: 149795
		[Token(Token = "0x4024923")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AsyncShow;

		// Token: 0x04024924 RID: 149796
		[Token(Token = "0x4024924")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x04024925 RID: 149797
		[Token(Token = "0x4024925")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004885 RID: 18565
		[Token(Token = "0x2004885")]
		public struct Data : IHotfixable
		{
			// Token: 0x0601C077 RID: 114807 RVA: 0x000A6F98 File Offset: 0x000A5198
			[Token(Token = "0x601C077")]
			[Address(RVA = "0x15653E0", Offset = "0x1563FE0", VA = "0x1815653E0")]
			public int InitData(MissionPeriodicRewardConf data_, int remainPoint_, int rewardState_, int serialNumber_)
			{
				return 0;
			}

			// Token: 0x04024926 RID: 149798
			[Token(Token = "0x4024926")]
			[FieldOffset(Offset = "0x0")]
			public MissionPeriodicRewardConf data;

			// Token: 0x04024927 RID: 149799
			[Token(Token = "0x4024927")]
			[FieldOffset(Offset = "0x8")]
			public int rewardState;

			// Token: 0x04024928 RID: 149800
			[Token(Token = "0x4024928")]
			[FieldOffset(Offset = "0xC")]
			public int completePoints;

			// Token: 0x04024929 RID: 149801
			[Token(Token = "0x4024929")]
			[FieldOffset(Offset = "0x10")]
			public int serialNumber;

			// Token: 0x0402492A RID: 149802
			[Token(Token = "0x402492A")]
			[FieldOffset(Offset = "0x14")]
			public bool isGetable;

			// Token: 0x0402492B RID: 149803
			[Token(Token = "0x402492B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitData;
		}
	}
}
