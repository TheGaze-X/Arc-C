using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x0200338B RID: 13195
	[Token(Token = "0x200338B")]
	public class UILifeLostGroup : MonoBehaviour
	{
		// Token: 0x170031FB RID: 12795
		// (set) Token: 0x060150A0 RID: 86176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031FB")]
		private int lifePointLossByEnemy
		{
			[Token(Token = "0x60150A0")]
			[Address(RVA = "0xD789B0", Offset = "0xD775B0", VA = "0x180D789B0")]
			set
			{
			}
		}

		// Token: 0x170031FC RID: 12796
		// (set) Token: 0x060150A1 RID: 86177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031FC")]
		private int lifePointLossByOthers
		{
			[Token(Token = "0x60150A1")]
			[Address(RVA = "0xD78B30", Offset = "0xD77730", VA = "0x180D78B30")]
			set
			{
			}
		}

		// Token: 0x060150A2 RID: 86178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150A2")]
		[Address(RVA = "0xD78880", Offset = "0xD77480", VA = "0x180D78880")]
		public void UpdateData(BattleController controller, bool force, PlayerSide side = PlayerSide.DEFAULT)
		{
		}

		// Token: 0x060150A3 RID: 86179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150A3")]
		[Address(RVA = "0xD78940", Offset = "0xD77540", VA = "0x180D78940")]
		public void UpdateData(int valueLifePointLossByEnemy, int valueLifePointLossByOthers, bool force)
		{
		}

		// Token: 0x060150A4 RID: 86180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150A4")]
		[Address(RVA = "0xD78820", Offset = "0xD77420", VA = "0x180D78820")]
		private void Awake()
		{
		}

		// Token: 0x060150A5 RID: 86181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60150A5")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UILifeLostGroup()
		{
		}

		// Token: 0x040190A9 RID: 102569
		[Token(Token = "0x40190A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _enemyLostLabel;

		// Token: 0x040190AA RID: 102570
		[Token(Token = "0x40190AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _enemyLostPoint;

		// Token: 0x040190AB RID: 102571
		[Token(Token = "0x40190AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _othersLostLabel;

		// Token: 0x040190AC RID: 102572
		[Token(Token = "0x40190AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _othersLostPoint;

		// Token: 0x040190AD RID: 102573
		[Token(Token = "0x40190AD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationClip _moveDownAnimation;

		// Token: 0x040190AE RID: 102574
		[Token(Token = "0x40190AE")]
		[FieldOffset(Offset = "0x40")]
		private Animation m_othersLostLabelAnimator;

		// Token: 0x040190AF RID: 102575
		[Token(Token = "0x40190AF")]
		[FieldOffset(Offset = "0x48")]
		private int m_lifePointLossByEnemy;

		// Token: 0x040190B0 RID: 102576
		[Token(Token = "0x40190B0")]
		private const string LOST_POINT_FORMAT = "-{0}";

		// Token: 0x040190B1 RID: 102577
		[Token(Token = "0x40190B1")]
		[FieldOffset(Offset = "0x4C")]
		private int m_lifePointLossByOthers;
	}
}
