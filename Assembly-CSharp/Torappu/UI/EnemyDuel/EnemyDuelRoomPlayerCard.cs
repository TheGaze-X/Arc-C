using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005055 RID: 20565
	[Token(Token = "0x2005055")]
	public class EnemyDuelRoomPlayerCard : MonoBehaviour
	{
		// Token: 0x0601E7BD RID: 124861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7BD")]
		[Address(RVA = "0x1830590", Offset = "0x182F190", VA = "0x181830590")]
		public void RenderViewModel(EnemyDuelRoomPlayerCardModel model)
		{
		}

		// Token: 0x17004728 RID: 18216
		// (get) Token: 0x0601E7BE RID: 124862 RVA: 0x000AE930 File Offset: 0x000ACB30
		// (set) Token: 0x0601E7BF RID: 124863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004728")]
		public bool kickValid
		{
			[Token(Token = "0x601E7BE")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601E7BF")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E7C0 RID: 124864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7C0")]
		[Address(RVA = "0x1830510", Offset = "0x182F110", VA = "0x181830510")]
		public void EventKick()
		{
		}

		// Token: 0x0601E7C1 RID: 124865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7C1")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public EnemyDuelRoomPlayerCard()
		{
		}

		// Token: 0x04028D52 RID: 167250
		[Token(Token = "0x4028D52")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x04028D53 RID: 167251
		[Token(Token = "0x4028D53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _btnKick;

		// Token: 0x04028D54 RID: 167252
		[Token(Token = "0x4028D54")]
		[FieldOffset(Offset = "0x28")]
		private EnemyDuelRoomPlayerCardModel m_model;
	}
}
