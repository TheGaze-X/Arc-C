using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000052 RID: 82
[Token(Token = "0x2000052")]
public class ETCInput : MonoBehaviour
{
	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000027")]
	public static ETCInput instance
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x505730", Offset = "0x504330", VA = "0x180505730")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x5023F0", Offset = "0x500FF0", VA = "0x1805023F0")]
	public void RegisterControl(ETCBase ctrl)
	{
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x505260", Offset = "0x503E60", VA = "0x180505260")]
	public void UnRegisterControl(ETCBase ctrl)
	{
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
	public void Create()
	{
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x502910", Offset = "0x501510", VA = "0x180502910")]
	public static void Register(ETCBase ctrl)
	{
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x505630", Offset = "0x504230", VA = "0x180505630")]
	public static void UnRegister(ETCBase ctrl)
	{
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x504B00", Offset = "0x503700", VA = "0x180504B00")]
	public static void SetControlVisible(string ctrlName, bool value)
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x501FF0", Offset = "0x500BF0", VA = "0x180501FF0")]
	public static bool GetControlVisible(string ctrlName)
	{
		return default(bool);
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x504630", Offset = "0x503230", VA = "0x180504630")]
	public static void SetControlActivated(string ctrlName, bool value)
	{
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002478 File Offset: 0x00000678
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x501600", Offset = "0x500200", VA = "0x180501600")]
	public static bool GetControlActivated(string ctrlName)
	{
		return default(bool);
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x5048C0", Offset = "0x5034C0", VA = "0x1805048C0")]
	public static void SetControlSwipeIn(string ctrlName, bool value)
	{
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002490 File Offset: 0x00000690
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x501C20", Offset = "0x500820", VA = "0x180501C20")]
	public static bool GetControlSwipeIn(string ctrlName)
	{
		return default(bool);
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000128")]
	[Address(RVA = "0x5049E0", Offset = "0x5035E0", VA = "0x1805049E0")]
	public static void SetControlSwipeOut(string ctrlName, bool value)
	{
	}

	// Token: 0x06000129 RID: 297 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x501D30", Offset = "0x500930", VA = "0x180501D30")]
	public static bool GetControlSwipeOut(string ctrlName, bool value)
	{
		return default(bool);
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012A")]
	[Address(RVA = "0x504C40", Offset = "0x503840", VA = "0x180504C40")]
	public static void SetDPadAxesCount(string ctrlName, ETCBase.DPadAxis value)
	{
	}

	// Token: 0x0600012B RID: 299 RVA: 0x000024C0 File Offset: 0x000006C0
	[Token(Token = "0x600012B")]
	[Address(RVA = "0x502100", Offset = "0x500D00", VA = "0x180502100")]
	public static ETCBase.DPadAxis GetDPadAxesCount(string ctrlName)
	{
		return ETCBase.DPadAxis.Two_Axis;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x501A70", Offset = "0x500670", VA = "0x180501A70")]
	public static ETCJoystick GetControlJoystick(string ctrlName)
	{
		return null;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012D")]
	[Address(RVA = "0x5018C0", Offset = "0x5004C0", VA = "0x1805018C0")]
	public static ETCDPad GetControlDPad(string ctrlName)
	{
		return null;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x501E40", Offset = "0x500A40", VA = "0x180501E40")]
	public static ETCTouchPad GetControlTouchPad(string ctrlName)
	{
		return null;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x501710", Offset = "0x500310", VA = "0x180501710")]
	public static ETCButton GetControlButton(string ctrlName)
	{
		return null;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x504770", Offset = "0x503370", VA = "0x180504770")]
	public static void SetControlSprite(string ctrlName, Sprite spr, [Optional] Color color)
	{
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000131")]
	[Address(RVA = "0x504D50", Offset = "0x503950", VA = "0x180504D50")]
	public static void SetJoystickThumbSprite(string ctrlName, Sprite spr, [Optional] Color color)
	{
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000132")]
	[Address(RVA = "0x5043E0", Offset = "0x502FE0", VA = "0x1805043E0")]
	public static void SetButtonSprite(string ctrlName, Sprite sprNormal, Sprite sprPress, [Optional] Color color)
	{
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000133")]
	[Address(RVA = "0x5041A0", Offset = "0x502DA0", VA = "0x1805041A0")]
	public static void SetAxisSpeed(string axisName, float speed)
	{
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000134")]
	[Address(RVA = "0x5037B0", Offset = "0x5023B0", VA = "0x1805037B0")]
	public static void SetAxisGravity(string axisName, float gravity)
	{
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000135")]
	[Address(RVA = "0x504FE0", Offset = "0x503BE0", VA = "0x180504FE0")]
	public static void SetTurnMoveSpeed(string ctrlName, float speed)
	{
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000136")]
	[Address(RVA = "0x502940", Offset = "0x501540", VA = "0x180502940")]
	public static void ResetAxis(string axisName)
	{
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000137")]
	[Address(RVA = "0x5036A0", Offset = "0x5022A0", VA = "0x1805036A0")]
	public static void SetAxisEnabled(string axisName, bool value)
	{
	}

	// Token: 0x06000138 RID: 312 RVA: 0x000024D8 File Offset: 0x000006D8
	[Token(Token = "0x6000138")]
	[Address(RVA = "0x500150", Offset = "0x4FED50", VA = "0x180500150")]
	public static bool GetAxisEnabled(string axisName)
	{
		return default(bool);
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000139")]
	[Address(RVA = "0x503C20", Offset = "0x502820", VA = "0x180503C20")]
	public static void SetAxisInverted(string axisName, bool value)
	{
	}

	// Token: 0x0600013A RID: 314 RVA: 0x000024F0 File Offset: 0x000006F0
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x500590", Offset = "0x4FF190", VA = "0x180500590")]
	public static bool GetAxisInverted(string axisName)
	{
		return default(bool);
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013B")]
	[Address(RVA = "0x503350", Offset = "0x501F50", VA = "0x180503350")]
	public static void SetAxisDeadValue(string axisName, float value)
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00002508 File Offset: 0x00000708
	[Token(Token = "0x600013C")]
	[Address(RVA = "0x4FFA20", Offset = "0x4FE620", VA = "0x1804FFA20")]
	public static float GetAxisDeadValue(string axisName)
	{
		return 0f;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013D")]
	[Address(RVA = "0x504080", Offset = "0x502C80", VA = "0x180504080")]
	public static void SetAxisSensitivity(string axisName, float value)
	{
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00002520 File Offset: 0x00000720
	[Token(Token = "0x600013E")]
	[Address(RVA = "0x500DD0", Offset = "0x4FF9D0", VA = "0x180500DD0")]
	public static float GetAxisSensitivity(string axisName)
	{
		return 0f;
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600013F")]
	[Address(RVA = "0x5042C0", Offset = "0x502EC0", VA = "0x1805042C0")]
	public static void SetAxisThreshold(string axisName, float value)
	{
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00002538 File Offset: 0x00000738
	[Token(Token = "0x6000140")]
	[Address(RVA = "0x500FE0", Offset = "0x4FFBE0", VA = "0x180500FE0")]
	public static float GetAxisThreshold(string axisName)
	{
		return 0f;
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000141")]
	[Address(RVA = "0x503B10", Offset = "0x502710", VA = "0x180503B10")]
	public static void SetAxisInertia(string axisName, bool value)
	{
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00002550 File Offset: 0x00000750
	[Token(Token = "0x6000142")]
	[Address(RVA = "0x500480", Offset = "0x4FF080", VA = "0x180500480")]
	public static bool GetAxisInertia(string axisName)
	{
		return default(bool);
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000143")]
	[Address(RVA = "0x5038D0", Offset = "0x5024D0", VA = "0x1805038D0")]
	public static void SetAxisInertiaSpeed(string axisName, float value)
	{
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00002568 File Offset: 0x00000768
	[Token(Token = "0x6000144")]
	[Address(RVA = "0x500260", Offset = "0x4FEE60", VA = "0x180500260")]
	public static float GetAxisInertiaSpeed(string axisName)
	{
		return 0f;
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000145")]
	[Address(RVA = "0x5039F0", Offset = "0x5025F0", VA = "0x1805039F0")]
	public static void SetAxisInertiaThreshold(string axisName, float value)
	{
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00002580 File Offset: 0x00000780
	[Token(Token = "0x6000146")]
	[Address(RVA = "0x500370", Offset = "0x4FEF70", VA = "0x180500370")]
	public static float GetAxisInertiaThreshold(string axisName)
	{
		return 0f;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000147")]
	[Address(RVA = "0x502DB0", Offset = "0x5019B0", VA = "0x180502DB0")]
	public static void SetAxisAutoStabilization(string axisName, bool value)
	{
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00002598 File Offset: 0x00000798
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x4FF5E0", Offset = "0x4FE1E0", VA = "0x1804FF5E0")]
	public static bool GetAxisAutoStabilization(string axisName)
	{
		return default(bool);
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000149")]
	[Address(RVA = "0x502B70", Offset = "0x501770", VA = "0x180502B70")]
	public static void SetAxisAutoStabilizationSpeed(string axisName, float value)
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x000025B0 File Offset: 0x000007B0
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x4FF3C0", Offset = "0x4FDFC0", VA = "0x1804FF3C0")]
	public static float GetAxisAutoStabilizationSpeed(string axisName)
	{
		return 0f;
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014B")]
	[Address(RVA = "0x502C90", Offset = "0x501890", VA = "0x180502C90")]
	public static void SetAxisAutoStabilizationThreshold(string axisName, float value)
	{
	}

	// Token: 0x0600014C RID: 332 RVA: 0x000025C8 File Offset: 0x000007C8
	[Token(Token = "0x600014C")]
	[Address(RVA = "0x4FF4D0", Offset = "0x4FE0D0", VA = "0x1804FF4D0")]
	public static float GetAxisAutoStabilizationThreshold(string axisName)
	{
		return 0f;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014D")]
	[Address(RVA = "0x503240", Offset = "0x501E40", VA = "0x180503240")]
	public static void SetAxisClampRotation(string axisName, bool value)
	{
	}

	// Token: 0x0600014E RID: 334 RVA: 0x000025E0 File Offset: 0x000007E0
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x4FF910", Offset = "0x4FE510", VA = "0x1804FF910")]
	public static bool GetAxisClampRotation(string axisName)
	{
		return default(bool);
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600014F")]
	[Address(RVA = "0x503100", Offset = "0x501D00", VA = "0x180503100")]
	public static void SetAxisClampRotationValue(string axisName, float min, float max)
	{
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x502FE0", Offset = "0x501BE0", VA = "0x180502FE0")]
	public static void SetAxisClampRotationMinValue(string axisName, float value)
	{
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000151")]
	[Address(RVA = "0x502EC0", Offset = "0x501AC0", VA = "0x180502EC0")]
	public static void SetAxisClampRotationMaxValue(string axisName, float value)
	{
	}

	// Token: 0x06000152 RID: 338 RVA: 0x000025F8 File Offset: 0x000007F8
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x4FF800", Offset = "0x4FE400", VA = "0x1804FF800")]
	public static float GetAxisClampRotationMinValue(string axisName)
	{
		return 0f;
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00002610 File Offset: 0x00000810
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x4FF6F0", Offset = "0x4FE2F0", VA = "0x1804FF6F0")]
	public static float GetAxisClampRotationMaxValue(string axisName)
	{
		return 0f;
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x503470", Offset = "0x502070", VA = "0x180503470")]
	public static void SetAxisDirecTransform(string axisName, Transform value)
	{
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x4FFC40", Offset = "0x4FE840", VA = "0x1804FFC40")]
	public static Transform GetAxisDirectTransform(string axisName)
	{
		return null;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000156")]
	[Address(RVA = "0x503590", Offset = "0x502190", VA = "0x180503590")]
	public static void SetAxisDirectAction(string axisName, ETCAxis.DirectAction value)
	{
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x4FFB30", Offset = "0x4FE730", VA = "0x1804FFB30")]
	public static ETCAxis.DirectAction GetAxisDirectAction(string axisName)
	{
		return ETCAxis.DirectAction.Rotate;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x502A60", Offset = "0x501660", VA = "0x180502A60")]
	public static void SetAxisAffectedAxis(string axisName, ETCAxis.AxisInfluenced value)
	{
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00002640 File Offset: 0x00000840
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x4FF2B0", Offset = "0x4FDEB0", VA = "0x1804FF2B0")]
	public static ETCAxis.AxisInfluenced GetAxisAffectedAxis(string axisName)
	{
		return ETCAxis.AxisInfluenced.X;
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015A")]
	[Address(RVA = "0x503F70", Offset = "0x502B70", VA = "0x180503F70")]
	public static void SetAxisOverTime(string axisName, bool value)
	{
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00002658 File Offset: 0x00000858
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x5008C0", Offset = "0x4FF4C0", VA = "0x1805008C0")]
	public static bool GetAxisOverTime(string axisName)
	{
		return default(bool);
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x503E50", Offset = "0x502A50", VA = "0x180503E50")]
	public static void SetAxisOverTimeStep(string axisName, float value)
	{
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00002670 File Offset: 0x00000870
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x5007B0", Offset = "0x4FF3B0", VA = "0x1805007B0")]
	public static float GetAxisOverTimeStep(string axisName)
	{
		return 0f;
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x503D30", Offset = "0x502930", VA = "0x180503D30")]
	public static void SetAxisOverTimeMaxValue(string axisName, float value)
	{
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00002688 File Offset: 0x00000888
	[Token(Token = "0x600015F")]
	[Address(RVA = "0x5006A0", Offset = "0x4FF2A0", VA = "0x1805006A0")]
	public static float GetAxisOverTimeMaxValue(string axisName)
	{
		return 0f;
	}

	// Token: 0x06000160 RID: 352 RVA: 0x000026A0 File Offset: 0x000008A0
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x5010F0", Offset = "0x4FFCF0", VA = "0x1805010F0")]
	public static float GetAxis(string axisName)
	{
		return 0f;
	}

	// Token: 0x06000161 RID: 353 RVA: 0x000026B8 File Offset: 0x000008B8
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x500EE0", Offset = "0x4FFAE0", VA = "0x180500EE0")]
	public static float GetAxisSpeed(string axisName)
	{
		return 0f;
	}

	// Token: 0x06000162 RID: 354 RVA: 0x000026D0 File Offset: 0x000008D0
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x500050", Offset = "0x4FEC50", VA = "0x180500050")]
	public static bool GetAxisDownUp(string axisName)
	{
		return default(bool);
	}

	// Token: 0x06000163 RID: 355 RVA: 0x000026E8 File Offset: 0x000008E8
	[Token(Token = "0x6000163")]
	[Address(RVA = "0x4FFD50", Offset = "0x4FE950", VA = "0x1804FFD50")]
	public static bool GetAxisDownDown(string axisName)
	{
		return default(bool);
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00002700 File Offset: 0x00000900
	[Token(Token = "0x6000164")]
	[Address(RVA = "0x4FFF50", Offset = "0x4FEB50", VA = "0x1804FFF50")]
	public static bool GetAxisDownRight(string axisName)
	{
		return default(bool);
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00002718 File Offset: 0x00000918
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x4FFE50", Offset = "0x4FEA50", VA = "0x1804FFE50")]
	public static bool GetAxisDownLeft(string axisName)
	{
		return default(bool);
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00002730 File Offset: 0x00000930
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x500CD0", Offset = "0x4FF8D0", VA = "0x180500CD0")]
	public static bool GetAxisPressedUp(string axisName)
	{
		return default(bool);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00002748 File Offset: 0x00000948
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x5009D0", Offset = "0x4FF5D0", VA = "0x1805009D0")]
	public static bool GetAxisPressedDown(string axisName)
	{
		return default(bool);
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00002760 File Offset: 0x00000960
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x500BD0", Offset = "0x4FF7D0", VA = "0x180500BD0")]
	public static bool GetAxisPressedRight(string axisName)
	{
		return default(bool);
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00002778 File Offset: 0x00000978
	[Token(Token = "0x6000169")]
	[Address(RVA = "0x500AD0", Offset = "0x4FF6D0", VA = "0x180500AD0")]
	public static bool GetAxisPressedLeft(string axisName)
	{
		return default(bool);
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00002790 File Offset: 0x00000990
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x501200", Offset = "0x4FFE00", VA = "0x180501200")]
	public static bool GetButtonDown(string buttonName)
	{
		return default(bool);
	}

	// Token: 0x0600016B RID: 363 RVA: 0x000027A8 File Offset: 0x000009A8
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x501500", Offset = "0x500100", VA = "0x180501500")]
	public static bool GetButton(string buttonName)
	{
		return default(bool);
	}

	// Token: 0x0600016C RID: 364 RVA: 0x000027C0 File Offset: 0x000009C0
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x501300", Offset = "0x4FFF00", VA = "0x180501300")]
	public static bool GetButtonUp(string buttonName)
	{
		return default(bool);
	}

	// Token: 0x0600016D RID: 365 RVA: 0x000027D8 File Offset: 0x000009D8
	[Token(Token = "0x600016D")]
	[Address(RVA = "0x501400", Offset = "0x500000", VA = "0x180501400")]
	public static float GetButtonValue(string buttonName)
	{
		return 0f;
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016E")]
	[Address(RVA = "0x5022E0", Offset = "0x500EE0", VA = "0x1805022E0")]
	private void RegisterAxis(ETCAxis axis)
	{
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016F")]
	[Address(RVA = "0x5051D0", Offset = "0x503DD0", VA = "0x1805051D0")]
	private void UnRegisterAxis(ETCAxis axis)
	{
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x502210", Offset = "0x500E10", VA = "0x180502210")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x505660", Offset = "0x504260", VA = "0x180505660")]
	public ETCInput()
	{
	}

	// Token: 0x04000173 RID: 371
	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ETCInput _instance;

	// Token: 0x04000174 RID: 372
	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, ETCAxis> axes;

	// Token: 0x04000175 RID: 373
	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, ETCBase> controls;

	// Token: 0x04000176 RID: 374
	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ETCBase control;

	// Token: 0x04000177 RID: 375
	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static ETCAxis axis;
}
