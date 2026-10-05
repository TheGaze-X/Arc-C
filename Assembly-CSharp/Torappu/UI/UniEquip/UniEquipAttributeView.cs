using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C21 RID: 15393
	[Token(Token = "0x2003C21")]
	public class UniEquipAttributeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601814E RID: 98638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601814E")]
		[Address(RVA = "0x1086190", Offset = "0x1084D90", VA = "0x181086190")]
		public void Render(AttributesData data, AttributesCalculator.AttributeRawDelta delta)
		{
		}

		// Token: 0x0601814F RID: 98639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601814F")]
		[Address(RVA = "0x1086870", Offset = "0x1085470", VA = "0x181086870")]
		private void _ApplyText(Text text, int value, int delta, bool eorFlag = false)
		{
		}

		// Token: 0x06018150 RID: 98640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018150")]
		[Address(RVA = "0x1086B80", Offset = "0x1085780", VA = "0x181086B80")]
		private void _ApplyText(Text text, float value, float delta)
		{
		}

		// Token: 0x06018151 RID: 98641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018151")]
		[Address(RVA = "0x1086600", Offset = "0x1085200", VA = "0x181086600")]
		private void _ApplySymbol(GameObject upSymbol, GameObject downSymbol, Text text, float delta, bool eorFlag = false)
		{
		}

		// Token: 0x06018152 RID: 98642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018152")]
		[Address(RVA = "0x1086EB0", Offset = "0x1085AB0", VA = "0x181086EB0")]
		public UniEquipAttributeView()
		{
		}

		// Token: 0x0401D351 RID: 119633
		[Token(Token = "0x401D351")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _maxHp;

		// Token: 0x0401D352 RID: 119634
		[Token(Token = "0x401D352")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _atk;

		// Token: 0x0401D353 RID: 119635
		[Token(Token = "0x401D353")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _def;

		// Token: 0x0401D354 RID: 119636
		[Token(Token = "0x401D354")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _res;

		// Token: 0x0401D355 RID: 119637
		[Token(Token = "0x401D355")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _reviveTime;

		// Token: 0x0401D356 RID: 119638
		[Token(Token = "0x401D356")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _reviveUpFlag;

		// Token: 0x0401D357 RID: 119639
		[Token(Token = "0x401D357")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _reviveDownFlag;

		// Token: 0x0401D358 RID: 119640
		[Token(Token = "0x401D358")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _cost;

		// Token: 0x0401D359 RID: 119641
		[Token(Token = "0x401D359")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _blockNum;

		// Token: 0x0401D35A RID: 119642
		[Token(Token = "0x401D35A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _atkSpeed;

		// Token: 0x0401D35B RID: 119643
		[Token(Token = "0x401D35B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _atkSpeedUpFlag;

		// Token: 0x0401D35C RID: 119644
		[Token(Token = "0x401D35C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _atkSpeedDownFlag;

		// Token: 0x0401D35D RID: 119645
		[Token(Token = "0x401D35D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D35E RID: 119646
		[Token(Token = "0x401D35E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyText;

		// Token: 0x0401D35F RID: 119647
		[Token(Token = "0x401D35F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1__ApplyText;

		// Token: 0x0401D360 RID: 119648
		[Token(Token = "0x401D360")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplySymbol;

		// Token: 0x0401D361 RID: 119649
		[Token(Token = "0x401D361")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
