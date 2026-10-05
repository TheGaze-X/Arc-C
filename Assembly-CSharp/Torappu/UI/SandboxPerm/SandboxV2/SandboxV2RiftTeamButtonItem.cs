using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004395 RID: 17301
	[Token(Token = "0x2004395")]
	public class SandboxV2RiftTeamButtonItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A903 RID: 108803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A903")]
		[Address(RVA = "0x13B7DD0", Offset = "0x13B69D0", VA = "0x1813B7DD0")]
		public void Render(string teamName, bool isSelected, string teamId)
		{
		}

		// Token: 0x0601A904 RID: 108804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A904")]
		[Address(RVA = "0x13B7FF0", Offset = "0x13B6BF0", VA = "0x1813B7FF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A905 RID: 108805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A905")]
		[Address(RVA = "0x13B7CF0", Offset = "0x13B68F0", VA = "0x1813B7CF0")]
		public void OnTeamSelected()
		{
		}

		// Token: 0x0601A906 RID: 108806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A906")]
		[Address(RVA = "0x13B7C60", Offset = "0x13B6860", VA = "0x1813B7C60")]
		public void OnTeamConfirmed()
		{
		}

		// Token: 0x0601A907 RID: 108807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A907")]
		[Address(RVA = "0x13B8110", Offset = "0x13B6D10", VA = "0x1813B8110")]
		public SandboxV2RiftTeamButtonItem()
		{
		}

		// Token: 0x04021D43 RID: 138563
		[Token(Token = "0x4021D43")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x04021D44 RID: 138564
		[Token(Token = "0x4021D44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _teamName;

		// Token: 0x04021D45 RID: 138565
		[Token(Token = "0x4021D45")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _confirmHotspot;

		// Token: 0x04021D46 RID: 138566
		[Token(Token = "0x4021D46")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04021D47 RID: 138567
		[Token(Token = "0x4021D47")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween m_switchTween;

		// Token: 0x04021D48 RID: 138568
		[Token(Token = "0x4021D48")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021D49 RID: 138569
		[Token(Token = "0x4021D49")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedTeamId;

		// Token: 0x04021D4A RID: 138570
		[Token(Token = "0x4021D4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021D4B RID: 138571
		[Token(Token = "0x4021D4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021D4C RID: 138572
		[Token(Token = "0x4021D4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTeamSelected;

		// Token: 0x04021D4D RID: 138573
		[Token(Token = "0x4021D4D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTeamConfirmed;

		// Token: 0x04021D4E RID: 138574
		[Token(Token = "0x4021D4E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
