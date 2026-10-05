using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B1D RID: 6941
	[Token(Token = "0x2001B1D")]
	[RequireComponent(typeof(RectTransform))]
	public class BuildingStationBPSlot : MonoBehaviour
	{
		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x0600AECA RID: 44746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014B5")]
		public string slotId
		{
			[Token(Token = "0x600AECA")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AECB RID: 44747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AECB")]
		[Address(RVA = "0x3292380", Offset = "0x3290F80", VA = "0x183292380")]
		public void Init(BuildingStationBlueprint layoutView, StationBPSlotStructModel slotModel, StationBPSlotStyle style = StationBPSlotStyle.LIGTH)
		{
		}

		// Token: 0x0600AECC RID: 44748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AECC")]
		[Address(RVA = "0x3292500", Offset = "0x3291100", VA = "0x183292500")]
		public void UpdateContent(StationBPSlotStructModel slotModel, bool force = false)
		{
		}

		// Token: 0x0600AECD RID: 44749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AECD")]
		[Address(RVA = "0x32926C0", Offset = "0x32912C0", VA = "0x1832926C0")]
		private void _UpdateRectTransform(BuildingStationBlueprint layoutView, StationBPSlotStructModel slotModel)
		{
		}

		// Token: 0x0600AECE RID: 44750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AECE")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingStationBPSlot()
		{
		}

		// Token: 0x0400A7E3 RID: 42979
		[Token(Token = "0x400A7E3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x0400A7E4 RID: 42980
		[Token(Token = "0x400A7E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectedMask;

		// Token: 0x0400A7E5 RID: 42981
		[Token(Token = "0x400A7E5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingStationBPSlot.ColorConfig _lightConfig;

		// Token: 0x0400A7E6 RID: 42982
		[Token(Token = "0x400A7E6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BuildingStationBPSlot.ColorConfig _darkConfig;

		// Token: 0x0400A7E7 RID: 42983
		[Token(Token = "0x400A7E7")]
		[FieldOffset(Offset = "0xA8")]
		private StationBPSlotStructModel m_slotModel;

		// Token: 0x0400A7E8 RID: 42984
		[Token(Token = "0x400A7E8")]
		[FieldOffset(Offset = "0xC8")]
		private BuildingStationBPSlot.ColorConfig m_colorConfig;

		// Token: 0x02001B1E RID: 6942
		[Token(Token = "0x2001B1E")]
		[Serializable]
		private struct ColorConfig
		{
			// Token: 0x0400A7E9 RID: 42985
			[Token(Token = "0x400A7E9")]
			[FieldOffset(Offset = "0x0")]
			public Color light;

			// Token: 0x0400A7EA RID: 42986
			[Token(Token = "0x400A7EA")]
			[FieldOffset(Offset = "0x10")]
			public Color normal;

			// Token: 0x0400A7EB RID: 42987
			[Token(Token = "0x400A7EB")]
			[FieldOffset(Offset = "0x20")]
			public Color lockedLight;

			// Token: 0x0400A7EC RID: 42988
			[Token(Token = "0x400A7EC")]
			[FieldOffset(Offset = "0x30")]
			public Color lockedNormal;
		}
	}
}
