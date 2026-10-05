using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.EnemyDuel
{
	// Token: 0x0200339F RID: 13215
	[Token(Token = "0x200339F")]
	public class UIEnemyDuelBattleStartPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015151 RID: 86353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015151")]
		[Address(RVA = "0xD96B20", Offset = "0xD95720", VA = "0x180D96B20")]
		public void Init()
		{
		}

		// Token: 0x06015152 RID: 86354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015152")]
		[Address(RVA = "0xD96EC0", Offset = "0xD95AC0", VA = "0x180D96EC0")]
		public void ShowLoop()
		{
		}

		// Token: 0x06015153 RID: 86355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015153")]
		[Address(RVA = "0xD96DF0", Offset = "0xD959F0", VA = "0x180D96DF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06015154 RID: 86356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015154")]
		[Address(RVA = "0xD970A0", Offset = "0xD95CA0", VA = "0x180D970A0")]
		public UIEnemyDuelBattleStartPanel()
		{
		}

		// Token: 0x04019198 RID: 102808
		[Token(Token = "0x4019198")]
		private const string DEFAULT_LOADING_PIC = "default";

		// Token: 0x04019199 RID: 102809
		[Token(Token = "0x4019199")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x0401919A RID: 102810
		[Token(Token = "0x401919A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIStageInfo _stageInfo;

		// Token: 0x0401919B RID: 102811
		[Token(Token = "0x401919B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation[] _loopAnims;

		// Token: 0x0401919C RID: 102812
		[Token(Token = "0x401919C")]
		[FieldOffset(Offset = "0x30")]
		private List<Tween> m_animTweens;

		// Token: 0x0401919D RID: 102813
		[Token(Token = "0x401919D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401919E RID: 102814
		[Token(Token = "0x401919E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowLoop;

		// Token: 0x0401919F RID: 102815
		[Token(Token = "0x401919F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040191A0 RID: 102816
		[Token(Token = "0x40191A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
