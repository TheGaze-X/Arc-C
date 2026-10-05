using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FC4 RID: 24516
	[Token(Token = "0x2005FC4")]
	public class CharacterInfoTalentGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023749 RID: 145225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023749")]
		[Address(RVA = "0x1E21C30", Offset = "0x1E20830", VA = "0x181E21C30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602374A RID: 145226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602374A")]
		[Address(RVA = "0x1E21A40", Offset = "0x1E20640", VA = "0x181E21A40")]
		public void RenderDesc(CharacterTalentViewModel[] talents)
		{
		}

		// Token: 0x0602374B RID: 145227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602374B")]
		[Address(RVA = "0x1E21D40", Offset = "0x1E20940", VA = "0x181E21D40")]
		public CharacterInfoTalentGroup()
		{
		}

		// Token: 0x0403109A RID: 200858
		[Token(Token = "0x403109A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403109B RID: 200859
		[Token(Token = "0x403109B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x0403109C RID: 200860
		[Token(Token = "0x403109C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0403109D RID: 200861
		[Token(Token = "0x403109D")]
		[FieldOffset(Offset = "0x30")]
		private CharacterInfoTalentGroup.Adapter m_adapter;

		// Token: 0x0403109E RID: 200862
		[Token(Token = "0x403109E")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0403109F RID: 200863
		[Token(Token = "0x403109F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040310A0 RID: 200864
		[Token(Token = "0x40310A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderDesc;

		// Token: 0x040310A1 RID: 200865
		[Token(Token = "0x40310A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005FC5 RID: 24517
		[Token(Token = "0x2005FC5")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170053AA RID: 21418
			// (get) Token: 0x0602374C RID: 145228 RVA: 0x000C0EB8 File Offset: 0x000BF0B8
			[Token(Token = "0x170053AA")]
			public override int count
			{
				[Token(Token = "0x602374C")]
				[Address(RVA = "0x1E13390", Offset = "0x1E11F90", VA = "0x181E13390", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602374D RID: 145229 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602374D")]
			[Address(RVA = "0x1E12E10", Offset = "0x1E11A10", VA = "0x181E12E10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602374E RID: 145230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602374E")]
			[Address(RVA = "0x1E13210", Offset = "0x1E11E10", VA = "0x181E13210")]
			public Adapter()
			{
			}

			// Token: 0x040310A2 RID: 200866
			[Token(Token = "0x40310A2")]
			[FieldOffset(Offset = "0x20")]
			public CharacterTalentViewModel[] talents;

			// Token: 0x040310A3 RID: 200867
			[Token(Token = "0x40310A3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040310A4 RID: 200868
			[Token(Token = "0x40310A4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040310A5 RID: 200869
			[Token(Token = "0x40310A5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
