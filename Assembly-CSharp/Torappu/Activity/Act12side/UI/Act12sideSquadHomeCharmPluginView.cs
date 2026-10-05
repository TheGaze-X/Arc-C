using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007ABD RID: 31421
	[Token(Token = "0x2007ABD")]
	public class Act12sideSquadHomeCharmPluginView : SquadHomeCharmPluginView
	{
		// Token: 0x0602C02A RID: 180266 RVA: 0x000DDE38 File Offset: 0x000DC038
		[Token(Token = "0x602C02A")]
		[Address(RVA = "0x27FFC10", Offset = "0x27FE810", VA = "0x1827FFC10", Slot = "10")]
		public override bool ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0602C02B RID: 180267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C02B")]
		[Address(RVA = "0x27FFC70", Offset = "0x27FE870", VA = "0x1827FFC70", Slot = "8")]
		public override void Show(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x0602C02C RID: 180268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C02C")]
		[Address(RVA = "0x27FFB40", Offset = "0x27FE740", VA = "0x1827FFB40", Slot = "14")]
		public override void EventOnEditCharmBtnClick()
		{
		}

		// Token: 0x0602C02D RID: 180269 RVA: 0x000DDE50 File Offset: 0x000DC050
		[Token(Token = "0x602C02D")]
		[Address(RVA = "0x28004C0", Offset = "0x27FF0C0", VA = "0x1828004C0")]
		private float _GetAngle(float lastAngle = 0f)
		{
			return 0f;
		}

		// Token: 0x0602C02E RID: 180270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C02E")]
		[Address(RVA = "0x28006B0", Offset = "0x27FF2B0", VA = "0x1828006B0")]
		private List<string> _RefreshCharmsList(SquadHomePlugin.PluginInputParams param)
		{
			return null;
		}

		// Token: 0x0602C02F RID: 180271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C02F")]
		[Address(RVA = "0x2800A40", Offset = "0x27FF640", VA = "0x182800A40")]
		private void _TryTriggerAVG()
		{
		}

		// Token: 0x0602C030 RID: 180272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C030")]
		[Address(RVA = "0x2800B10", Offset = "0x27FF710", VA = "0x182800B10")]
		public Act12sideSquadHomeCharmPluginView()
		{
		}

		// Token: 0x0602C031 RID: 180273 RVA: 0x000DDE68 File Offset: 0x000DC068
		[Token(Token = "0x602C031")]
		[Address(RVA = "0x1872C40", Offset = "0x1871840", VA = "0x181872C40")]
		private bool <>xLuaBaseProxy_ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0403FC54 RID: 261204
		[Token(Token = "0x403FC54")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Transform> _btnAdds;

		// Token: 0x0403FC55 RID: 261205
		[Token(Token = "0x403FC55")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Act12sideSquadHomeCharmPluginItemView> _charmItems;

		// Token: 0x0403FC56 RID: 261206
		[Token(Token = "0x403FC56")]
		[FieldOffset(Offset = "0x40")]
		private bool m_canEdit;

		// Token: 0x0403FC57 RID: 261207
		[Token(Token = "0x403FC57")]
		private const float ROTATE_MIN_ANGLE_1 = -34f;

		// Token: 0x0403FC58 RID: 261208
		[Token(Token = "0x403FC58")]
		private const float ROTATE_MAX_ANGLE_1 = 34f;

		// Token: 0x0403FC59 RID: 261209
		[Token(Token = "0x403FC59")]
		private const float ROTATE_MIN_ANGLE_2 = -8f;

		// Token: 0x0403FC5A RID: 261210
		[Token(Token = "0x403FC5A")]
		private const float ROTATE_MAX_ANGLE_2 = 12f;

		// Token: 0x0403FC5B RID: 261211
		[Token(Token = "0x403FC5B")]
		private const float ROTATE_MIN_ANGLE_3 = -24f;

		// Token: 0x0403FC5C RID: 261212
		[Token(Token = "0x403FC5C")]
		private const float ROTATE_MAX_ANGLE_3 = 18f;

		// Token: 0x0403FC5D RID: 261213
		[Token(Token = "0x403FC5D")]
		private const float MIN_DIFF = 10f;

		// Token: 0x0403FC5E RID: 261214
		[Token(Token = "0x403FC5E")]
		private const int RANDOM_TYPE_COUNT = 4;

		// Token: 0x0403FC5F RID: 261215
		[Token(Token = "0x403FC5F")]
		[FieldOffset(Offset = "0x44")]
		private readonly Vector3 VIEW_POS;

		// Token: 0x0403FC60 RID: 261216
		[Token(Token = "0x403FC60")]
		private const float INIT_ICON_LOCAL_ROTATE = 30f;

		// Token: 0x0403FC61 RID: 261217
		[Token(Token = "0x403FC61")]
		private const float TOLERANCE = 0.01f;

		// Token: 0x0403FC62 RID: 261218
		[Token(Token = "0x403FC62")]
		[FieldOffset(Offset = "0x50")]
		private List<string> m_charmList;

		// Token: 0x0403FC63 RID: 261219
		[Token(Token = "0x403FC63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowSquadLeftArrow;

		// Token: 0x0403FC64 RID: 261220
		[Token(Token = "0x403FC64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403FC65 RID: 261221
		[Token(Token = "0x403FC65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnEditCharmBtnClick;

		// Token: 0x0403FC66 RID: 261222
		[Token(Token = "0x403FC66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetAngle;

		// Token: 0x0403FC67 RID: 261223
		[Token(Token = "0x403FC67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshCharmsList;

		// Token: 0x0403FC68 RID: 261224
		[Token(Token = "0x403FC68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryTriggerAVG;

		// Token: 0x0403FC69 RID: 261225
		[Token(Token = "0x403FC69")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
