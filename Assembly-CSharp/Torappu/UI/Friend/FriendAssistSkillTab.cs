using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DA4 RID: 19876
	[Token(Token = "0x2004DA4")]
	public class FriendAssistSkillTab : MonoBehaviour
	{
		// Token: 0x0601DBA2 RID: 121762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBA2")]
		[Address(RVA = "0x173DA80", Offset = "0x173C680", VA = "0x18173DA80")]
		public void ResetData()
		{
		}

		// Token: 0x0601DBA3 RID: 121763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBA3")]
		[Address(RVA = "0x173D680", Offset = "0x173C280", VA = "0x18173D680")]
		public void ApplyData(string skillName, int skillLvl, bool assign, bool unlocked)
		{
		}

		// Token: 0x0601DBA4 RID: 121764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBA4")]
		[Address(RVA = "0x173D8B0", Offset = "0x173C4B0", VA = "0x18173D8B0")]
		public void ApplyData(SkillData skillData, bool assign, bool unlocked)
		{
		}

		// Token: 0x0601DBA5 RID: 121765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBA5")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public FriendAssistSkillTab()
		{
		}

		// Token: 0x040274EB RID: 161003
		[Token(Token = "0x40274EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ThreeStateToggle _stateControl;

		// Token: 0x040274EC RID: 161004
		[Token(Token = "0x40274EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x040274ED RID: 161005
		[Token(Token = "0x40274ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _skillIcon;

		// Token: 0x040274EE RID: 161006
		[Token(Token = "0x40274EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _skillName;

		// Token: 0x040274EF RID: 161007
		[Token(Token = "0x40274EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _SelectState;

		// Token: 0x040274F0 RID: 161008
		[Token(Token = "0x40274F0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _speicailizedIcon;
	}
}
