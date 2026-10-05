using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A8A RID: 6794
	[Token(Token = "0x2001A8A")]
	public class VCharCtrlStatusIcon : VOUIPanel
	{
		// Token: 0x0600AB4A RID: 43850 RVA: 0x000423F0 File Offset: 0x000405F0
		[Token(Token = "0x600AB4A")]
		[Address(RVA = "0x3253DD0", Offset = "0x32529D0", VA = "0x183253DD0", Slot = "4")]
		public override bool MatchObject(BuildingEvent evt, VRoom.Object roomObject)
		{
			return default(bool);
		}

		// Token: 0x0600AB4B RID: 43851 RVA: 0x00042408 File Offset: 0x00040608
		[Token(Token = "0x600AB4B")]
		[Address(RVA = "0x3254290", Offset = "0x3252E90", VA = "0x183254290")]
		private bool _MatchObjectWhenVisit(BuildingEvent evt, VRoom.Object roomObject)
		{
			return default(bool);
		}

		// Token: 0x0600AB4C RID: 43852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB4C")]
		[Address(RVA = "0x32540A0", Offset = "0x3252CA0", VA = "0x1832540A0", Slot = "9")]
		protected override void UpdateRender()
		{
		}

		// Token: 0x0600AB4D RID: 43853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB4D")]
		[Address(RVA = "0x3253DC0", Offset = "0x32529C0", VA = "0x183253DC0")]
		public VCharCtrlStatusIcon()
		{
		}

		// Token: 0x0400A392 RID: 41874
		[Token(Token = "0x400A392")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _iconCtrlTagAlpha;

		// Token: 0x0400A393 RID: 41875
		[Token(Token = "0x400A393")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_ctrlTagIconSwitch;
	}
}
