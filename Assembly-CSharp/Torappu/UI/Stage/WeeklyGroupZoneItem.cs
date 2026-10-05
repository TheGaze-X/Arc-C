using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006794 RID: 26516
	[Token(Token = "0x2006794")]
	public class WeeklyGroupZoneItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x170059F8 RID: 23032
		// (get) Token: 0x06026086 RID: 155782 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026087 RID: 155783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059F8")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x6026086")]
			[Address(RVA = "0x2128790", Offset = "0x2127390", VA = "0x182128790")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026087")]
			[Address(RVA = "0x21287F0", Offset = "0x21273F0", VA = "0x1821287F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026088 RID: 155784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026088")]
		[Address(RVA = "0x2127C30", Offset = "0x2126830", VA = "0x182127C30")]
		public void Render(int position, ZoneViewModel zoneModel)
		{
		}

		// Token: 0x06026089 RID: 155785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026089")]
		[Address(RVA = "0x2128400", Offset = "0x2127000", VA = "0x182128400")]
		private string _ParseOpenText(WeekStruct<ZoneOpenDetailState> weekInfo)
		{
			return null;
		}

		// Token: 0x0602608A RID: 155786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602608A")]
		[Address(RVA = "0x2127B40", Offset = "0x2126740", VA = "0x182127B40")]
		public void OnItemClick()
		{
		}

		// Token: 0x0602608B RID: 155787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602608B")]
		[Address(RVA = "0x2128730", Offset = "0x2127330", VA = "0x182128730")]
		public WeeklyGroupZoneItem()
		{
		}

		// Token: 0x04035808 RID: 219144
		[Token(Token = "0x4035808")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Display Part")]
		private GameObject _goDisablePart;

		// Token: 0x04035809 RID: 219145
		[Token(Token = "0x4035809")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Display Part")]
		private GameObject _goWillOpenPart;

		// Token: 0x0403580A RID: 219146
		[Token(Token = "0x403580A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Display Part")]
		private GameObject _goLockPart;

		// Token: 0x0403580B RID: 219147
		[Token(Token = "0x403580B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Display Part")]
		private GameObject _goForceOpenPart;

		// Token: 0x0403580C RID: 219148
		[Token(Token = "0x403580C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Display Part")]
		private GameObject _goNormalPart;

		// Token: 0x0403580D RID: 219149
		[Token(Token = "0x403580D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Display Part")]
		private Text _textOpenTime;

		// Token: 0x0403580E RID: 219150
		[Token(Token = "0x403580E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgBg;

		// Token: 0x0403580F RID: 219151
		[Token(Token = "0x403580F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04035810 RID: 219152
		[Token(Token = "0x4035810")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textUnlockInfo;

		// Token: 0x04035811 RID: 219153
		[Token(Token = "0x4035811")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _unlockStageParam;

		// Token: 0x04035812 RID: 219154
		[Token(Token = "0x4035812")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private WeeklyGroupZoneIconWidget _iconWidget;

		// Token: 0x04035813 RID: 219155
		[Token(Token = "0x4035813")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int _offsetTime;

		// Token: 0x04035814 RID: 219156
		[Token(Token = "0x4035814")]
		private const float NORMAL_PART_ALPHA = 0.3f;

		// Token: 0x04035815 RID: 219157
		[Token(Token = "0x4035815")]
		[FieldOffset(Offset = "0x74")]
		private bool m_isUnlock;

		// Token: 0x04035817 RID: 219159
		[Token(Token = "0x4035817")]
		[FieldOffset(Offset = "0x80")]
		private WeeklyZoneViewModel m_zoneModel;

		// Token: 0x04035818 RID: 219160
		[Token(Token = "0x4035818")]
		[FieldOffset(Offset = "0x88")]
		private GameObject m_timelyObj;

		// Token: 0x04035819 RID: 219161
		[Token(Token = "0x4035819")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403581A RID: 219162
		[Token(Token = "0x403581A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403581B RID: 219163
		[Token(Token = "0x403581B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403581C RID: 219164
		[Token(Token = "0x403581C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ParseOpenText;

		// Token: 0x0403581D RID: 219165
		[Token(Token = "0x403581D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403581E RID: 219166
		[Token(Token = "0x403581E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
