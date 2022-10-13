using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectNutritionist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double calories = 0;

        double grams;

        private void btn_cereals_Click(object sender, EventArgs e)
        {
            //  BUTTONS //

            btn_add.Visible = true;
            btn_add1.Visible = false;
            btn_add2.Visible = false;
            btn_add3.Visible = false;
            btn_add4.Visible = false;
            btn_add5.Visible = false;
            btn_add6.Visible = false;
            btn_add7.Visible = false;

            // CEREALS //

            lbl_barley.Visible = true;
            lbl_refined_flour.Visible = true;
            lbl_rice.Visible = true;
            lbl_rice_flakes.Visible = true;
            lbl_wheat_flour.Visible = true;
            lbl_bajra.Visible = true;
            lbl_jowar.Visible = true;
            lbl_quinoa.Visible = true;
            lbl_ragi.Visible = true;
            lbl_semolina.Visible = true;
            lbl_vermicelli.Visible = true;

            lbl_cal_barley.Visible = true;
            lbl_cal_refined_flour.Visible = true;
            lbl_cal_rice.Visible = true;
            lbl_cal_rice_flakes.Visible = true;
            lbl_cal_wheat_flour.Visible = true;
            lbl_cal_bajra.Visible = true;
            lbl_cal_jowar.Visible = true;
            lbl_cal_quinoa.Visible = true;
            lbl_cal_ragi.Visible = true;
            lbl_cal_semolina.Visible = true;
            lbl_cal_vermicelli.Visible = true;

            txtbox_barley.Visible = true;
            txtbox_refined_flour.Visible = true;
            txtbox_rice.Visible = true;
            txtbox_rice_flakes.Visible = true;
            txtbox_wheat_flour.Visible = true;
            txtbox_bajra.Visible = true;
            txtbox_jowar.Visible = true;
            txtbox_quinoa.Visible = true;
            txtbox_ragi.Visible = true;
            txtbox_semolina.Visible = true;
            txtbox_vermicelli.Visible = true;

            //  VEGETABLES //

            lbl_bottle.Visible = false;
            lbl_bitter.Visible = false;
            lbl_brinjal.Visible = false;
            lbl_capsicum.Visible = false;
            lbl_cauliflower.Visible = false;
            lbl_cucumber.Visible = false;
            lbl_french.Visible = false;
            lbl_lady.Visible = false;
            lbl_peas.Visible = false;
            lbl_pumpkin.Visible = false;
            lbl_tomato.Visible = false;
            lbl_beetroot.Visible = false;
            lbl_carrot.Visible = false;
            lbl_potato.Visible = false;
            lbl_radish.Visible = false;
            lbl_sweet.Visible = false;
            lbl_ash.Visible = false;

            lbl_cal_bottle.Visible = false;
            lbl_cal_bitter.Visible = false;
            lbl_cal_brinjal.Visible = false;
            lbl_cal_capsicum.Visible = false;
            lbl_cal_cauliflower.Visible = false;
            lbl_cal_cucumber.Visible = false;
            lbl_cal_french.Visible = false;
            lbl_cal_lady.Visible = false;
            lbl_cal_peas.Visible = false;
            lbl_cal_pumpkin.Visible = false;
            lbl_cal_tomato.Visible = false;
            lbl_cal_beetroot.Visible = false;
            lbl_cal_carrot.Visible = false;
            lbl_cal_potato.Visible = false;
            lbl_cal_radish.Visible = false;
            lbl_cal_sweet.Visible = false;
            lbl_cal_ash.Visible = false;

            txtbox_bottle.Visible = false;
            txtbox_bitter.Visible = false;
            txtbox_brinjal.Visible = false;
            txtbox_capsicum.Visible = false;
            txtbox_cauliflower.Visible = false;
            txtbox_cucumber.Visible = false;
            txtbox_french.Visible = false;
            txtbox_lady.Visible = false;
            txtbox_peas.Visible = false;
            txtbox_pumpkin.Visible = false;
            txtbox_tomato.Visible = false;
            txtbox_beetroot.Visible = false;
            txtbox_carrot.Visible = false;
            txtbox_potato.Visible = false;
            txtbox_radish.Visible = false;
            txtbox_sweet.Visible = false;
            txtbox_ash.Visible = false;

            // GREEN-LEAFY VEGETABLES //

            lbl_spinach.Visible = false;
            lbl_radish_leaves.Visible = false;
            lbl_parsley.Visible = false;
            lbl_lettuce.Visible = false;
            lbl_cauliflower_leaves.Visible = false;
            lbl_cabbage.Visible = false;
            lbl_brussel.Visible = false;
            lbl_fenugreek.Visible = false;
            lbl_beet.Visible = false;
            lbl_drumstick.Visible = false;

            lbl_cal_spinach.Visible = false;
            lbl_cal_radish_leaves.Visible = false;
            lbl_cal_parsley.Visible = false;
            lbl_cal_lettuce.Visible = false;
            lbl_cal_cauliflower_leaves.Visible = false;
            lbl_cal_cabbage.Visible = false;
            lbl_cal_brussel.Visible = false;
            lbl_cal_fenugreek.Visible = false;
            lbl_cal_beet.Visible = false;
            lbl_cal_drumstick.Visible = false;

            txtbox_spinach.Visible = false;
            txtbox_radish_leaves.Visible = false;
            txtbox_parsley.Visible = false;
            txtbox_lettuce.Visible = false;
            txtbox_cauliflower_leaves.Visible = false;
            txtbox_cabbage.Visible = false;
            txtbox_brussel.Visible = false;
            txtbox_fenugreek.Visible = false;
            txtbox_beet.Visible = false;
            txtbox_drumstick.Visible = false;

            // FRUITS //

            lbl_apple.Visible = false;
            lbl_watermelon.Visible = false;
            lbl_strawberry.Visible = false;
            lbl_banana.Visible = false;
            lbl_cherries.Visible = false;
            lbl_grapes.Visible = false;
            lbl_pomegranate.Visible = false;
            lbl_pear.Visible = false;
            lbl_guava.Visible = false;
            lbl_blackcurrants.Visible = false;
            lbl_plum.Visible = false;
            lbl_litchi.Visible = false;
            lbl_pineapple.Visible = false;
            lbl_mango.Visible = false;
            lbl_orange.Visible = false;
            lbl_peach.Visible = false;
            lbl_musk.Visible = false;
            lbl_avocado.Visible = false;
            lbl_dry.Visible = false;

            lbl_cal_apple.Visible = false;
            lbl_cal_watermelon.Visible = false;
            lbl_cal_strawberry.Visible = false;
            lbl_cal_banana.Visible = false;
            lbl_cal_cherries.Visible = false;
            lbl_cal_grapes.Visible = false;
            lbl_cal_pomegranate.Visible = false;
            lbl_cal_pear.Visible = false;
            lbl_cal_guava.Visible = false;
            lbl_cal_blackcurrants.Visible = false;
            lbl_cal_plum.Visible = false;
            lbl_cal_litchi.Visible = false;
            lbl_cal_pineapple.Visible = false;
            lbl_cal_mango.Visible = false;
            lbl_cal_orange.Visible = false;
            lbl_cal_peach.Visible = false;
            lbl_cal_musk.Visible = false;
            lbl_cal_avocado.Visible = false;
            lbl_cal_dry.Visible = false;

            txtbox_apple.Visible = false;
            txtbox_watermelon.Visible = false;
            txtbox_strawberry.Visible = false;
            txtbox_banana.Visible = false;
            txtbox_cherries.Visible = false;
            txtbox_grapes.Visible = false;
            txtbox_pomegranate.Visible = false;
            txtbox_pear.Visible = false;
            txtbox_guava.Visible = false;
            txtbox_blackcurrants.Visible = false;
            txtbox_plum.Visible = false;
            txtbox_litchi.Visible = false;
            txtbox_pineapple.Visible = false;
            txtbox_mango.Visible = false;
            txtbox_orange.Visible = false;
            txtbox_peach.Visible = false;
            txtbox_musk.Visible = false;
            txtbox_avocado.Visible = false;
            txtbox_dry.Visible = false;

            // SPICES AND CONDIMENTS //

            lbl_turmeric.Visible = false;
            lbl_black_pepper.Visible = false;
            lbl_fenugeek_seeds.Visible = false;
            lbl_kalonji.Visible = false;
            lbl_cumin.Visible = false;
            lbl_cloves.Visible = false;
            lbl_red_chillies.Visible = false;
            lbl_green_cardamom.Visible = false;
            lbl_poppy.Visible = false;
            lbl_asafoetida.Visible = false;
            lbl_mint.Visible = false;
            lbl_ginger.Visible = false;
            lbl_garlic.Visible = false;
            lbl_curry.Visible = false;
            lbl_nutmeg.Visible = false;
            lbl_coriander.Visible = false;
            lbl_green_chillies.Visible = false;
            lbl_dry_coconut.Visible = false;

            lbl_cal_turmeric.Visible = false;
            lbl_cal_black_pepper.Visible = false;
            lbl_cal_fenugeek_seeds.Visible = false;
            lbl_cal_kalonji.Visible = false;
            lbl_cal_cumin.Visible = false;
            lbl_cal_cloves.Visible = false;
            lbl_cal_red_chillies.Visible = false;
            lbl_cal_green_cardamom.Visible = false;
            lbl_cal_poppy.Visible = false;
            lbl_cal_asafoetida.Visible = false;
            lbl_cal_mint.Visible = false;
            lbl_cal_ginger.Visible = false;
            lbl_cal_garlic.Visible = false;
            lbl_cal_curry.Visible = false;
            lbl_cal_nutmeg.Visible = false;
            lbl_cal_coriander.Visible = false;
            lbl_cal_green_chillies.Visible = false;
            lbl_cal_dry_coconut.Visible = false;

            txtbox_turmeric.Visible = false;
            txtbox_black_pepper.Visible = false;
            txtbox_fenugeek_seeds.Visible = false;
            txtbox_kalonji.Visible = false;
            txtbox_cumin.Visible = false;
            txtbox_cloves.Visible = false;
            txtbox_red_chillies.Visible = false;
            txtbox_green_cardamom.Visible = false;
            txtbox_poppy.Visible = false;
            txtbox_asafoetida.Visible = false;
            txtbox_mint.Visible = false;
            txtbox_ginger.Visible = false;
            txtbox_garlic.Visible = false;
            txtbox_curry.Visible = false;
            txtbox_nutmeg.Visible = false;
            txtbox_coriander.Visible = false;
            txtbox_green_chillies.Visible = false;
            txtbox_dry_coconut.Visible = false;

            // NON-VEG FOODS //

            lbl_egg_white.Visible = false;
            lbl_egg_yolk.Visible = false;
            lbl_chicken_leg.Visible = false;
            lbl_chicken_thigh.Visible = false;
            lbl_chicken_breast.Visible = false;
            lbl_chicken_liver.Visible = false;
            lbl_pork.Visible = false;
            lbl_sheep.Visible = false;
            lbl_pomfret.Visible = false;
            lbl_tuna.Visible = false;
            lbl_salmon.Visible = false;
            lbl_crab.Visible = false;
            lbl_oyster.Visible = false;

            lbl_cal_egg_white.Visible = false;
            lbl_cal_egg_yolk.Visible = false;
            lbl_cal_chicken_leg.Visible = false;
            lbl_cal_chicken_thigh.Visible = false;
            lbl_cal_chicken_breast.Visible = false;
            lbl_cal_chicken_liver.Visible = false;
            lbl_cal_pork.Visible = false;
            lbl_cal_sheep.Visible = false;
            lbl_cal_pomfret.Visible = false;
            lbl_cal_tuna.Visible = false;
            lbl_cal_salmon.Visible = false;
            lbl_cal_crab.Visible = false;
            lbl_cal_oyster.Visible = false;

            txtbox_egg_white.Visible = false;
            txtbox_egg_yolk.Visible = false;
            txtbox_chicken_leg.Visible = false;
            txtbox_chicken_thigh.Visible = false;
            txtbox_chicken_breast.Visible = false;
            txtbox_chicken_liver.Visible = false;
            txtbox_pork.Visible = false;
            txtbox_sheep.Visible = false;
            txtbox_pomfret.Visible = false;
            txtbox_tuna.Visible = false;
            txtbox_salmon.Visible = false;
            txtbox_crab.Visible = false;
            txtbox_oyster.Visible = false;

            // NUTS AND SEEDS //

            lbl_almond.Visible = false;
            lbl_cashew.Visible = false;
            lbl_ground.Visible = false;
            lbl_linseeds.Visible = false;
            lbl_pine.Visible = false;
            lbl_pistachio.Visible = false;
            lbl_sunflower.Visible = false;
            lbl_walnut.Visible = false;
            lbl_flax.Visible = false;
            lbl_chia.Visible = false;

            lbl_cal_almond.Visible = false;
            lbl_cal_cashew.Visible = false;
            lbl_cal_ground.Visible = false;
            lbl_cal_linseeds.Visible = false;
            lbl_cal_pine.Visible = false;
            lbl_cal_pistachio.Visible = false;
            lbl_cal_sunflower.Visible = false;
            lbl_cal_walnut.Visible = false;
            lbl_cal_flax.Visible = false;
            lbl_cal_chia.Visible = false;

            txtbox_almond.Visible = false;
            txtbox_cashew.Visible = false;
            txtbox_ground.Visible = false;
            txtbox_linseeds.Visible = false;
            txtbox_pine.Visible = false;
            txtbox_pistachio.Visible = false;
            txtbox_sunflower.Visible = false;
            txtbox_walnut.Visible = false;
            txtbox_flax.Visible = false;
            txtbox_chia.Visible = false;

            // MILK PRODUCTS //

            lbl_buffalo.Visible = false;
            lbl_cow.Visible = false;
            lbl_soy.Visible = false;
            lbl_tofu.Visible = false;
            lbl_paneer.Visible = false;
            lbl_cheese.Visible = false;
            lbl_khoa.Visible = false;

            lbl_cal_buffalo.Visible = false;
            lbl_cal_cow.Visible = false;
            lbl_cal_soy.Visible = false;
            lbl_cal_tofu.Visible = false;
            lbl_cal_paneer.Visible = false;
            lbl_cal_cheese.Visible = false;
            lbl_cal_khoa.Visible = false;

            txtbox_buffalo.Visible = false;
            txtbox_cow.Visible = false;
            txtbox_soy.Visible = false;
            txtbox_tofu.Visible = false;
            txtbox_paneer.Visible = false;
            txtbox_cheese.Visible = false;
            txtbox_khoa.Visible = false;
        }

        private void btn_vegetables_Click(object sender, EventArgs e)
        {
            //  BUTTONS //

            btn_add.Visible = false;
            btn_add1.Visible = true;
            btn_add2.Visible = false;
            btn_add3.Visible = false;
            btn_add4.Visible = false;
            btn_add5.Visible = false;
            btn_add6.Visible = false;
            btn_add7.Visible = false;

            // CEREALS //

            lbl_barley.Visible = false;
            lbl_refined_flour.Visible = false;
            lbl_rice.Visible = false;
            lbl_rice_flakes.Visible = false;
            lbl_wheat_flour.Visible = false;
            lbl_bajra.Visible = false;
            lbl_jowar.Visible = false;
            lbl_quinoa.Visible = false;
            lbl_ragi.Visible = false;
            lbl_semolina.Visible = false;
            lbl_vermicelli.Visible = false;

            lbl_cal_barley.Visible = false;
            lbl_cal_refined_flour.Visible = false;
            lbl_cal_rice.Visible = false;
            lbl_cal_rice_flakes.Visible = false;
            lbl_cal_wheat_flour.Visible = false;
            lbl_cal_bajra.Visible = false;
            lbl_cal_jowar.Visible = false;
            lbl_cal_quinoa.Visible = false;
            lbl_cal_ragi.Visible = false;
            lbl_cal_semolina.Visible = false;
            lbl_cal_vermicelli.Visible = false;

            txtbox_barley.Visible = false;
            txtbox_refined_flour.Visible = false;
            txtbox_rice.Visible = false;
            txtbox_rice_flakes.Visible = false;
            txtbox_wheat_flour.Visible = false;
            txtbox_bajra.Visible = false; ;
            txtbox_jowar.Visible = false;
            txtbox_quinoa.Visible = false;
            txtbox_ragi.Visible = false;
            txtbox_semolina.Visible = false;
            txtbox_vermicelli.Visible = false;

            //  VEGETABLES //

            lbl_bottle.Visible = true;
            lbl_bitter.Visible = true;
            lbl_brinjal.Visible = true;
            lbl_capsicum.Visible = true;
            lbl_cauliflower.Visible = true;
            lbl_cucumber.Visible = true;
            lbl_french.Visible = true;
            lbl_lady.Visible = true;
            lbl_peas.Visible = true;
            lbl_pumpkin.Visible = true;
            lbl_tomato.Visible = true;
            lbl_beetroot.Visible = true;
            lbl_carrot.Visible = true;
            lbl_potato.Visible = true;
            lbl_radish.Visible = true;
            lbl_sweet.Visible = true;
            lbl_ash.Visible = true;

            lbl_cal_bottle.Visible = true;
            lbl_cal_bitter.Visible = true;
            lbl_cal_brinjal.Visible = true;
            lbl_cal_capsicum.Visible = true;
            lbl_cal_cauliflower.Visible = true;
            lbl_cal_cucumber.Visible = true;
            lbl_cal_french.Visible = true;
            lbl_cal_lady.Visible = true;
            lbl_cal_peas.Visible = true;
            lbl_cal_pumpkin.Visible = true;
            lbl_cal_tomato.Visible = true;
            lbl_cal_beetroot.Visible = true;
            lbl_cal_carrot.Visible = true;
            lbl_cal_potato.Visible = true;
            lbl_cal_radish.Visible = true;
            lbl_cal_sweet.Visible = true;
            lbl_cal_ash.Visible = true;

            txtbox_bottle.Visible = true;
            txtbox_bitter.Visible = true;
            txtbox_brinjal.Visible = true;
            txtbox_capsicum.Visible = true;
            txtbox_cauliflower.Visible = true;
            txtbox_cucumber.Visible = true;
            txtbox_french.Visible = true;
            txtbox_lady.Visible = true;
            txtbox_peas.Visible = true;
            txtbox_pumpkin.Visible = true;
            txtbox_tomato.Visible = true;
            txtbox_beetroot.Visible = true;
            txtbox_carrot.Visible = true;
            txtbox_potato.Visible = true;
            txtbox_radish.Visible = true;
            txtbox_sweet.Visible = true;
            txtbox_ash.Visible = true;

            // GREEN-LEAFY VEGETABLES //

            lbl_spinach.Visible = false;
            lbl_radish_leaves.Visible = false;
            lbl_parsley.Visible = false;
            lbl_lettuce.Visible = false;
            lbl_cauliflower_leaves.Visible = false;
            lbl_cabbage.Visible = false;
            lbl_brussel.Visible = false;
            lbl_fenugreek.Visible = false;
            lbl_beet.Visible = false;
            lbl_drumstick.Visible = false;

            lbl_cal_spinach.Visible = false;
            lbl_cal_radish_leaves.Visible = false;
            lbl_cal_parsley.Visible = false;
            lbl_cal_lettuce.Visible = false;
            lbl_cal_cauliflower_leaves.Visible = false;
            lbl_cal_cabbage.Visible = false;
            lbl_cal_brussel.Visible = false;
            lbl_cal_fenugreek.Visible = false;
            lbl_cal_beet.Visible = false;
            lbl_cal_drumstick.Visible = false;

            txtbox_spinach.Visible = false;
            txtbox_radish_leaves.Visible = false;
            txtbox_parsley.Visible = false;
            txtbox_lettuce.Visible = false;
            txtbox_cauliflower_leaves.Visible = false;
            txtbox_cabbage.Visible = false;
            txtbox_brussel.Visible = false;
            txtbox_fenugreek.Visible = false;
            txtbox_beet.Visible = false;
            txtbox_drumstick.Visible = false;

            // FRUITS //

            lbl_apple.Visible = false;
            lbl_watermelon.Visible = false;
            lbl_strawberry.Visible = false;
            lbl_banana.Visible = false;
            lbl_cherries.Visible = false;
            lbl_grapes.Visible = false;
            lbl_pomegranate.Visible = false;
            lbl_pear.Visible = false;
            lbl_guava.Visible = false;
            lbl_blackcurrants.Visible = false;
            lbl_plum.Visible = false;
            lbl_litchi.Visible = false;
            lbl_pineapple.Visible = false;
            lbl_mango.Visible = false;
            lbl_orange.Visible = false;
            lbl_peach.Visible = false;
            lbl_musk.Visible = false;
            lbl_avocado.Visible = false;
            lbl_dry.Visible = false;

            lbl_cal_apple.Visible = false;
            lbl_cal_watermelon.Visible = false;
            lbl_cal_strawberry.Visible = false;
            lbl_cal_banana.Visible = false;
            lbl_cal_cherries.Visible = false;
            lbl_cal_grapes.Visible = false;
            lbl_cal_pomegranate.Visible = false;
            lbl_cal_pear.Visible = false;
            lbl_cal_guava.Visible = false;
            lbl_cal_blackcurrants.Visible = false;
            lbl_cal_plum.Visible = false;
            lbl_cal_litchi.Visible = false;
            lbl_cal_pineapple.Visible = false;
            lbl_cal_mango.Visible = false;
            lbl_cal_orange.Visible = false;
            lbl_cal_peach.Visible = false;
            lbl_cal_musk.Visible = false;
            lbl_cal_avocado.Visible = false;
            lbl_cal_dry.Visible = false;

            txtbox_apple.Visible = false;
            txtbox_watermelon.Visible = false;
            txtbox_strawberry.Visible = false;
            txtbox_banana.Visible = false;
            txtbox_cherries.Visible = false;
            txtbox_grapes.Visible = false;
            txtbox_pomegranate.Visible = false;
            txtbox_pear.Visible = false;
            txtbox_guava.Visible = false;
            txtbox_blackcurrants.Visible = false;
            txtbox_plum.Visible = false;
            txtbox_litchi.Visible = false;
            txtbox_pineapple.Visible = false;
            txtbox_mango.Visible = false;
            txtbox_orange.Visible = false;
            txtbox_peach.Visible = false;
            txtbox_musk.Visible = false;
            txtbox_avocado.Visible = false;
            txtbox_dry.Visible = false;

            // SPICES AND CONDIMENTS //

            lbl_turmeric.Visible = false;
            lbl_black_pepper.Visible = false;
            lbl_fenugeek_seeds.Visible = false;
            lbl_kalonji.Visible = false;
            lbl_cumin.Visible = false;
            lbl_cloves.Visible = false;
            lbl_red_chillies.Visible = false;
            lbl_green_cardamom.Visible = false;
            lbl_poppy.Visible = false;
            lbl_asafoetida.Visible = false;
            lbl_mint.Visible = false;
            lbl_ginger.Visible = false;
            lbl_garlic.Visible = false;
            lbl_curry.Visible = false;
            lbl_nutmeg.Visible = false;
            lbl_coriander.Visible = false;
            lbl_green_chillies.Visible = false;
            lbl_dry_coconut.Visible = false;

            lbl_cal_turmeric.Visible = false;
            lbl_cal_black_pepper.Visible = false;
            lbl_cal_fenugeek_seeds.Visible = false;
            lbl_cal_kalonji.Visible = false;
            lbl_cal_cumin.Visible = false;
            lbl_cal_cloves.Visible = false;
            lbl_cal_red_chillies.Visible = false;
            lbl_cal_green_cardamom.Visible = false;
            lbl_cal_poppy.Visible = false;
            lbl_cal_asafoetida.Visible = false;
            lbl_cal_mint.Visible = false;
            lbl_cal_ginger.Visible = false;
            lbl_cal_garlic.Visible = false;
            lbl_cal_curry.Visible = false;
            lbl_cal_nutmeg.Visible = false;
            lbl_cal_coriander.Visible = false;
            lbl_cal_green_chillies.Visible = false;
            lbl_cal_dry_coconut.Visible = false;

            txtbox_turmeric.Visible = false;
            txtbox_black_pepper.Visible = false;
            txtbox_fenugeek_seeds.Visible = false;
            txtbox_kalonji.Visible = false;
            txtbox_cumin.Visible = false;
            txtbox_cloves.Visible = false;
            txtbox_red_chillies.Visible = false;
            txtbox_green_cardamom.Visible = false;
            txtbox_poppy.Visible = false;
            txtbox_asafoetida.Visible = false;
            txtbox_mint.Visible = false;
            txtbox_ginger.Visible = false;
            txtbox_garlic.Visible = false;
            txtbox_curry.Visible = false;
            txtbox_nutmeg.Visible = false;
            txtbox_coriander.Visible = false;
            txtbox_green_chillies.Visible = false;
            txtbox_dry_coconut.Visible = false;

            // NON-VEG FOODS //

            lbl_egg_white.Visible = false;
            lbl_egg_yolk.Visible = false;
            lbl_chicken_leg.Visible = false;
            lbl_chicken_thigh.Visible = false;
            lbl_chicken_breast.Visible = false;
            lbl_chicken_liver.Visible = false;
            lbl_pork.Visible = false;
            lbl_sheep.Visible = false;
            lbl_pomfret.Visible = false;
            lbl_tuna.Visible = false;
            lbl_salmon.Visible = false;
            lbl_crab.Visible = false;
            lbl_oyster.Visible = false;

            lbl_cal_egg_white.Visible = false;
            lbl_cal_egg_yolk.Visible = false;
            lbl_cal_chicken_leg.Visible = false;
            lbl_cal_chicken_thigh.Visible = false;
            lbl_cal_chicken_breast.Visible = false;
            lbl_cal_chicken_liver.Visible = false;
            lbl_cal_pork.Visible = false;
            lbl_cal_sheep.Visible = false;
            lbl_cal_pomfret.Visible = false;
            lbl_cal_tuna.Visible = false;
            lbl_cal_salmon.Visible = false;
            lbl_cal_crab.Visible = false;
            lbl_cal_oyster.Visible = false;

            txtbox_egg_white.Visible = false;
            txtbox_egg_yolk.Visible = false;
            txtbox_chicken_leg.Visible = false;
            txtbox_chicken_thigh.Visible = false;
            txtbox_chicken_breast.Visible = false;
            txtbox_chicken_liver.Visible = false;
            txtbox_pork.Visible = false;
            txtbox_sheep.Visible = false;
            txtbox_pomfret.Visible = false;
            txtbox_tuna.Visible = false;
            txtbox_salmon.Visible = false;
            txtbox_crab.Visible = false;
            txtbox_oyster.Visible = false;

            // NUTS AND SEEDS //

            lbl_almond.Visible = false;
            lbl_cashew.Visible = false;
            lbl_ground.Visible = false;
            lbl_linseeds.Visible = false;
            lbl_pine.Visible = false;
            lbl_pistachio.Visible = false;
            lbl_sunflower.Visible = false;
            lbl_walnut.Visible = false;
            lbl_flax.Visible = false;
            lbl_chia.Visible = false;

            lbl_cal_almond.Visible = false;
            lbl_cal_cashew.Visible = false;
            lbl_cal_ground.Visible = false;
            lbl_cal_linseeds.Visible = false;
            lbl_cal_pine.Visible = false;
            lbl_cal_pistachio.Visible = false;
            lbl_cal_sunflower.Visible = false;
            lbl_cal_walnut.Visible = false;
            lbl_cal_flax.Visible = false;
            lbl_cal_chia.Visible = false;

            txtbox_almond.Visible = false;
            txtbox_cashew.Visible = false;
            txtbox_ground.Visible = false;
            txtbox_linseeds.Visible = false;
            txtbox_pine.Visible = false;
            txtbox_pistachio.Visible = false;
            txtbox_sunflower.Visible = false;
            txtbox_walnut.Visible = false;
            txtbox_flax.Visible = false;
            txtbox_chia.Visible = false;

            // MILK PRODUCTS //

            lbl_buffalo.Visible = false;
            lbl_cow.Visible = false;
            lbl_soy.Visible = false;
            lbl_tofu.Visible = false;
            lbl_paneer.Visible = false;
            lbl_cheese.Visible = false;
            lbl_khoa.Visible = false;

            lbl_cal_buffalo.Visible = false;
            lbl_cal_cow.Visible = false;
            lbl_cal_soy.Visible = false;
            lbl_cal_tofu.Visible = false;
            lbl_cal_paneer.Visible = false;
            lbl_cal_cheese.Visible = false;
            lbl_cal_khoa.Visible = false;

            txtbox_buffalo.Visible = false;
            txtbox_cow.Visible = false;
            txtbox_soy.Visible = false;
            txtbox_tofu.Visible = false;
            txtbox_paneer.Visible = false;
            txtbox_cheese.Visible = false;
            txtbox_khoa.Visible = false;
        }

        private void btn_green_leafy_Click(object sender, EventArgs e)
        {
            //  BUTTONS //

            btn_add.Visible = false;
            btn_add1.Visible = false;
            btn_add2.Visible = true;
            btn_add3.Visible = false;
            btn_add4.Visible = false;
            btn_add5.Visible = false;
            btn_add6.Visible = false;
            btn_add7.Visible = false;

            // CEREALS //

            lbl_barley.Visible = false;
            lbl_refined_flour.Visible = false;
            lbl_rice.Visible = false;
            lbl_rice_flakes.Visible = false;
            lbl_wheat_flour.Visible = false;
            lbl_bajra.Visible = false;
            lbl_jowar.Visible = false;
            lbl_quinoa.Visible = false;
            lbl_ragi.Visible = false;
            lbl_semolina.Visible = false;
            lbl_vermicelli.Visible = false;

            lbl_cal_barley.Visible = false;
            lbl_cal_refined_flour.Visible = false;
            lbl_cal_rice.Visible = false;
            lbl_cal_rice_flakes.Visible = false;
            lbl_cal_wheat_flour.Visible = false;
            lbl_cal_bajra.Visible = false;
            lbl_cal_jowar.Visible = false;
            lbl_cal_quinoa.Visible = false;
            lbl_cal_ragi.Visible = false;
            lbl_cal_semolina.Visible = false;
            lbl_cal_vermicelli.Visible = false;

            txtbox_barley.Visible = false;
            txtbox_refined_flour.Visible = false;
            txtbox_rice.Visible = false;
            txtbox_rice_flakes.Visible = false;
            txtbox_wheat_flour.Visible = false;
            txtbox_bajra.Visible = false; ;
            txtbox_jowar.Visible = false;
            txtbox_quinoa.Visible = false;
            txtbox_ragi.Visible = false;
            txtbox_semolina.Visible = false;
            txtbox_vermicelli.Visible = false;

            //  VEGETABLES //

            lbl_bottle.Visible = false;
            lbl_bitter.Visible = false;
            lbl_brinjal.Visible = false;
            lbl_capsicum.Visible = false;
            lbl_cauliflower.Visible = false;
            lbl_cucumber.Visible = false;
            lbl_french.Visible = false;
            lbl_lady.Visible = false;
            lbl_peas.Visible = false;
            lbl_pumpkin.Visible = false;
            lbl_tomato.Visible = false;
            lbl_beetroot.Visible = false;
            lbl_carrot.Visible = false;
            lbl_potato.Visible = false;
            lbl_radish.Visible = false;
            lbl_sweet.Visible = false;
            lbl_ash.Visible = false;

            lbl_cal_bottle.Visible = false;
            lbl_cal_bitter.Visible = false;
            lbl_cal_brinjal.Visible = false;
            lbl_cal_capsicum.Visible = false;
            lbl_cal_cauliflower.Visible = false;
            lbl_cal_cucumber.Visible = false;
            lbl_cal_french.Visible = false;
            lbl_cal_lady.Visible = false;
            lbl_cal_peas.Visible = false;
            lbl_cal_pumpkin.Visible = false;
            lbl_cal_tomato.Visible = false;
            lbl_cal_beetroot.Visible = false;
            lbl_cal_carrot.Visible = false;
            lbl_cal_potato.Visible = false;
            lbl_cal_radish.Visible = false;
            lbl_cal_sweet.Visible = false;
            lbl_cal_ash.Visible = false;

            txtbox_bottle.Visible = false;
            txtbox_bitter.Visible = false;
            txtbox_brinjal.Visible = false;
            txtbox_capsicum.Visible = false;
            txtbox_cauliflower.Visible = false;
            txtbox_cucumber.Visible = false;
            txtbox_french.Visible = false;
            txtbox_lady.Visible = false;
            txtbox_peas.Visible = false;
            txtbox_pumpkin.Visible = false;
            txtbox_tomato.Visible = false;
            txtbox_beetroot.Visible = false;
            txtbox_carrot.Visible = false;
            txtbox_potato.Visible = false;
            txtbox_radish.Visible = false;
            txtbox_sweet.Visible = false;
            txtbox_ash.Visible = false;

            // GREEN-LEAFY VEGETABLES //

            lbl_spinach.Visible = true;
            lbl_radish_leaves.Visible = true;
            lbl_parsley.Visible = true;
            lbl_lettuce.Visible = true;
            lbl_cauliflower_leaves.Visible = true;
            lbl_cabbage.Visible = true;
            lbl_brussel.Visible = true;
            lbl_fenugreek.Visible = true;
            lbl_beet.Visible = true;
            lbl_drumstick.Visible = true;

            lbl_cal_spinach.Visible = true;
            lbl_cal_radish_leaves.Visible = true;
            lbl_cal_parsley.Visible = true;
            lbl_cal_lettuce.Visible = true;
            lbl_cal_cauliflower_leaves.Visible = true;
            lbl_cal_cabbage.Visible = true;
            lbl_cal_brussel.Visible = true;
            lbl_cal_fenugreek.Visible = true;
            lbl_cal_beet.Visible = true;
            lbl_cal_drumstick.Visible = true;

            txtbox_spinach.Visible = true;
            txtbox_radish_leaves.Visible = true;
            txtbox_parsley.Visible = true;
            txtbox_lettuce.Visible = true;
            txtbox_cauliflower_leaves.Visible = true;
            txtbox_cabbage.Visible = true;
            txtbox_brussel.Visible = true;
            txtbox_fenugreek.Visible = true;
            txtbox_beet.Visible = true;
            txtbox_drumstick.Visible = true;

            // FRUITS //

            lbl_apple.Visible = false;
            lbl_watermelon.Visible = false;
            lbl_strawberry.Visible = false;
            lbl_banana.Visible = false;
            lbl_cherries.Visible = false;
            lbl_grapes.Visible = false;
            lbl_pomegranate.Visible = false;
            lbl_pear.Visible = false;
            lbl_guava.Visible = false;
            lbl_blackcurrants.Visible = false;
            lbl_plum.Visible = false;
            lbl_litchi.Visible = false;
            lbl_pineapple.Visible = false;
            lbl_mango.Visible = false;
            lbl_orange.Visible = false;
            lbl_peach.Visible = false;
            lbl_musk.Visible = false;
            lbl_avocado.Visible = false;
            lbl_dry.Visible = false;

            lbl_cal_apple.Visible = false;
            lbl_cal_watermelon.Visible = false;
            lbl_cal_strawberry.Visible = false;
            lbl_cal_banana.Visible = false;
            lbl_cal_cherries.Visible = false;
            lbl_cal_grapes.Visible = false;
            lbl_cal_pomegranate.Visible = false;
            lbl_cal_pear.Visible = false;
            lbl_cal_guava.Visible = false;
            lbl_cal_blackcurrants.Visible = false;
            lbl_cal_plum.Visible = false;
            lbl_cal_litchi.Visible = false;
            lbl_cal_pineapple.Visible = false;
            lbl_cal_mango.Visible = false;
            lbl_cal_orange.Visible = false;
            lbl_cal_peach.Visible = false;
            lbl_cal_musk.Visible = false;
            lbl_cal_avocado.Visible = false;
            lbl_cal_dry.Visible = false;

            txtbox_apple.Visible = false;
            txtbox_watermelon.Visible = false;
            txtbox_strawberry.Visible = false;
            txtbox_banana.Visible = false;
            txtbox_cherries.Visible = false;
            txtbox_grapes.Visible = false;
            txtbox_pomegranate.Visible = false;
            txtbox_pear.Visible = false;
            txtbox_guava.Visible = false;
            txtbox_blackcurrants.Visible = false;
            txtbox_plum.Visible = false;
            txtbox_litchi.Visible = false;
            txtbox_pineapple.Visible = false;
            txtbox_mango.Visible = false;
            txtbox_orange.Visible = false;
            txtbox_peach.Visible = false;
            txtbox_musk.Visible = false;
            txtbox_avocado.Visible = false;
            txtbox_dry.Visible = false;

            // SPICES AND CONDIMENTS //

            lbl_turmeric.Visible = false;
            lbl_black_pepper.Visible = false;
            lbl_fenugeek_seeds.Visible = false;
            lbl_kalonji.Visible = false;
            lbl_cumin.Visible = false;
            lbl_cloves.Visible = false;
            lbl_red_chillies.Visible = false;
            lbl_green_cardamom.Visible = false;
            lbl_poppy.Visible = false;
            lbl_asafoetida.Visible = false;
            lbl_mint.Visible = false;
            lbl_ginger.Visible = false;
            lbl_garlic.Visible = false;
            lbl_curry.Visible = false;
            lbl_nutmeg.Visible = false;
            lbl_coriander.Visible = false;
            lbl_green_chillies.Visible = false;
            lbl_dry_coconut.Visible = false;

            lbl_cal_turmeric.Visible = false;
            lbl_cal_black_pepper.Visible = false;
            lbl_cal_fenugeek_seeds.Visible = false;
            lbl_cal_kalonji.Visible = false;
            lbl_cal_cumin.Visible = false;
            lbl_cal_cloves.Visible = false;
            lbl_cal_red_chillies.Visible = false;
            lbl_cal_green_cardamom.Visible = false;
            lbl_cal_poppy.Visible = false;
            lbl_cal_asafoetida.Visible = false;
            lbl_cal_mint.Visible = false;
            lbl_cal_ginger.Visible = false;
            lbl_cal_garlic.Visible = false;
            lbl_cal_curry.Visible = false;
            lbl_cal_nutmeg.Visible = false;
            lbl_cal_coriander.Visible = false;
            lbl_cal_green_chillies.Visible = false;
            lbl_cal_dry_coconut.Visible = false;

            txtbox_turmeric.Visible = false;
            txtbox_black_pepper.Visible = false;
            txtbox_fenugeek_seeds.Visible = false;
            txtbox_kalonji.Visible = false;
            txtbox_cumin.Visible = false;
            txtbox_cloves.Visible = false;
            txtbox_red_chillies.Visible = false;
            txtbox_green_cardamom.Visible = false;
            txtbox_poppy.Visible = false;
            txtbox_asafoetida.Visible = false;
            txtbox_mint.Visible = false;
            txtbox_ginger.Visible = false;
            txtbox_garlic.Visible = false;
            txtbox_curry.Visible = false;
            txtbox_nutmeg.Visible = false;
            txtbox_coriander.Visible = false;
            txtbox_green_chillies.Visible = false;
            txtbox_dry_coconut.Visible = false;

            // NON-VEG FOODS //

            lbl_egg_white.Visible = false;
            lbl_egg_yolk.Visible = false;
            lbl_chicken_leg.Visible = false;
            lbl_chicken_thigh.Visible = false;
            lbl_chicken_breast.Visible = false;
            lbl_chicken_liver.Visible = false;
            lbl_pork.Visible = false;
            lbl_sheep.Visible = false;
            lbl_pomfret.Visible = false;
            lbl_tuna.Visible = false;
            lbl_salmon.Visible = false;
            lbl_crab.Visible = false;
            lbl_oyster.Visible = false;

            lbl_cal_egg_white.Visible = false;
            lbl_cal_egg_yolk.Visible = false;
            lbl_cal_chicken_leg.Visible = false;
            lbl_cal_chicken_thigh.Visible = false;
            lbl_cal_chicken_breast.Visible = false;
            lbl_cal_chicken_liver.Visible = false;
            lbl_cal_pork.Visible = false;
            lbl_cal_sheep.Visible = false;
            lbl_cal_pomfret.Visible = false;
            lbl_cal_tuna.Visible = false;
            lbl_cal_salmon.Visible = false;
            lbl_cal_crab.Visible = false;
            lbl_cal_oyster.Visible = false;

            txtbox_egg_white.Visible = false;
            txtbox_egg_yolk.Visible = false;
            txtbox_chicken_leg.Visible = false;
            txtbox_chicken_thigh.Visible = false;
            txtbox_chicken_breast.Visible = false;
            txtbox_chicken_liver.Visible = false;
            txtbox_pork.Visible = false;
            txtbox_sheep.Visible = false;
            txtbox_pomfret.Visible = false;
            txtbox_tuna.Visible = false;
            txtbox_salmon.Visible = false;
            txtbox_crab.Visible = false;
            txtbox_oyster.Visible = false;

            // NUTS AND SEEDS //

            lbl_almond.Visible = false;
            lbl_cashew.Visible = false;
            lbl_ground.Visible = false;
            lbl_linseeds.Visible = false;
            lbl_pine.Visible = false;
            lbl_pistachio.Visible = false;
            lbl_sunflower.Visible = false;
            lbl_walnut.Visible = false;
            lbl_flax.Visible = false;
            lbl_chia.Visible = false;

            lbl_cal_almond.Visible = false;
            lbl_cal_cashew.Visible = false;
            lbl_cal_ground.Visible = false;
            lbl_cal_linseeds.Visible = false;
            lbl_cal_pine.Visible = false;
            lbl_cal_pistachio.Visible = false;
            lbl_cal_sunflower.Visible = false;
            lbl_cal_walnut.Visible = false;
            lbl_cal_flax.Visible = false;
            lbl_cal_chia.Visible = false;

            txtbox_almond.Visible = false;
            txtbox_cashew.Visible = false;
            txtbox_ground.Visible = false;
            txtbox_linseeds.Visible = false;
            txtbox_pine.Visible = false;
            txtbox_pistachio.Visible = false;
            txtbox_sunflower.Visible = false;
            txtbox_walnut.Visible = false;
            txtbox_flax.Visible = false;
            txtbox_chia.Visible = false;

            // MILK PRODUCTS //

            lbl_buffalo.Visible = false;
            lbl_cow.Visible = false;
            lbl_soy.Visible = false;
            lbl_tofu.Visible = false;
            lbl_paneer.Visible = false;
            lbl_cheese.Visible = false;
            lbl_khoa.Visible = false;

            lbl_cal_buffalo.Visible = false;
            lbl_cal_cow.Visible = false;
            lbl_cal_soy.Visible = false;
            lbl_cal_tofu.Visible = false;
            lbl_cal_paneer.Visible = false;
            lbl_cal_cheese.Visible = false;
            lbl_cal_khoa.Visible = false;

            txtbox_buffalo.Visible = false;
            txtbox_cow.Visible = false;
            txtbox_soy.Visible = false;
            txtbox_tofu.Visible = false;
            txtbox_paneer.Visible = false;
            txtbox_cheese.Visible = false;
            txtbox_khoa.Visible = false;
        }

        private void btn_fruits_Click(object sender, EventArgs e)
        {
            //  BUTTONS //

            btn_add.Visible = false;
            btn_add1.Visible = false;
            btn_add2.Visible = false;
            btn_add3.Visible = true;
            btn_add4.Visible = false;
            btn_add5.Visible = false;
            btn_add6.Visible = false;
            btn_add7.Visible = false;

            // CEREALS //

            lbl_barley.Visible = false;
            lbl_refined_flour.Visible = false;
            lbl_rice.Visible = false;
            lbl_rice_flakes.Visible = false;
            lbl_wheat_flour.Visible = false;
            lbl_bajra.Visible = false;
            lbl_jowar.Visible = false;
            lbl_quinoa.Visible = false;
            lbl_ragi.Visible = false;
            lbl_semolina.Visible = false;
            lbl_vermicelli.Visible = false;

            lbl_cal_barley.Visible = false;
            lbl_cal_refined_flour.Visible = false;
            lbl_cal_rice.Visible = false;
            lbl_cal_rice_flakes.Visible = false;
            lbl_cal_wheat_flour.Visible = false;
            lbl_cal_bajra.Visible = false;
            lbl_cal_jowar.Visible = false;
            lbl_cal_quinoa.Visible = false;
            lbl_cal_ragi.Visible = false;
            lbl_cal_semolina.Visible = false;
            lbl_cal_vermicelli.Visible = false;

            txtbox_barley.Visible = false;
            txtbox_refined_flour.Visible = false;
            txtbox_rice.Visible = false;
            txtbox_rice_flakes.Visible = false;
            txtbox_wheat_flour.Visible = false;
            txtbox_bajra.Visible = false; ;
            txtbox_jowar.Visible = false;
            txtbox_quinoa.Visible = false;
            txtbox_ragi.Visible = false;
            txtbox_semolina.Visible = false;
            txtbox_vermicelli.Visible = false;

            //  VEGETABLES //

            lbl_bottle.Visible = false;
            lbl_bitter.Visible = false;
            lbl_brinjal.Visible = false;
            lbl_capsicum.Visible = false;
            lbl_cauliflower.Visible = false;
            lbl_cucumber.Visible = false;
            lbl_french.Visible = false;
            lbl_lady.Visible = false;
            lbl_peas.Visible = false;
            lbl_pumpkin.Visible = false;
            lbl_tomato.Visible = false;
            lbl_beetroot.Visible = false;
            lbl_carrot.Visible = false;
            lbl_potato.Visible = false;
            lbl_radish.Visible = false;
            lbl_sweet.Visible = false;
            lbl_ash.Visible = false;

            lbl_cal_bottle.Visible = false;
            lbl_cal_bitter.Visible = false;
            lbl_cal_brinjal.Visible = false;
            lbl_cal_capsicum.Visible = false;
            lbl_cal_cauliflower.Visible = false;
            lbl_cal_cucumber.Visible = false;
            lbl_cal_french.Visible = false;
            lbl_cal_lady.Visible = false;
            lbl_cal_peas.Visible = false;
            lbl_cal_pumpkin.Visible = false;
            lbl_cal_tomato.Visible = false;
            lbl_cal_beetroot.Visible = false;
            lbl_cal_carrot.Visible = false;
            lbl_cal_potato.Visible = false;
            lbl_cal_radish.Visible = false;
            lbl_cal_sweet.Visible = false;
            lbl_cal_ash.Visible = false;

            txtbox_bottle.Visible = false;
            txtbox_bitter.Visible = false;
            txtbox_brinjal.Visible = false;
            txtbox_capsicum.Visible = false;
            txtbox_cauliflower.Visible = false;
            txtbox_cucumber.Visible = false;
            txtbox_french.Visible = false;
            txtbox_lady.Visible = false;
            txtbox_peas.Visible = false;
            txtbox_pumpkin.Visible = false;
            txtbox_tomato.Visible = false;
            txtbox_beetroot.Visible = false;
            txtbox_carrot.Visible = false;
            txtbox_potato.Visible = false;
            txtbox_radish.Visible = false;
            txtbox_sweet.Visible = false;
            txtbox_ash.Visible = false;

            // GREEN-LEAFY VEGETABLES //

            lbl_spinach.Visible = false;
            lbl_radish_leaves.Visible = false;
            lbl_parsley.Visible = false;
            lbl_lettuce.Visible = false;
            lbl_cauliflower_leaves.Visible = false;
            lbl_cabbage.Visible = false;
            lbl_brussel.Visible = false;
            lbl_fenugreek.Visible = false;
            lbl_beet.Visible = false;
            lbl_drumstick.Visible = false;

            lbl_cal_spinach.Visible = false;
            lbl_cal_radish_leaves.Visible = false;
            lbl_cal_parsley.Visible = false;
            lbl_cal_lettuce.Visible = false;
            lbl_cal_cauliflower_leaves.Visible = false;
            lbl_cal_cabbage.Visible = false;
            lbl_cal_brussel.Visible = false;
            lbl_cal_fenugreek.Visible = false;
            lbl_cal_beet.Visible = false;
            lbl_cal_drumstick.Visible = false;

            txtbox_spinach.Visible = false;
            txtbox_radish_leaves.Visible = false;
            txtbox_parsley.Visible = false;
            txtbox_lettuce.Visible = false;
            txtbox_cauliflower_leaves.Visible = false;
            txtbox_cabbage.Visible = false;
            txtbox_brussel.Visible = false;
            txtbox_fenugreek.Visible = false;
            txtbox_beet.Visible = false;
            txtbox_drumstick.Visible = false;

            // FRUITS //

            lbl_apple.Visible = true;
            lbl_watermelon.Visible = true;
            lbl_strawberry.Visible = true;
            lbl_banana.Visible = true;
            lbl_cherries.Visible = true;
            lbl_grapes.Visible = true;
            lbl_pomegranate.Visible = true;
            lbl_pear.Visible = true;
            lbl_guava.Visible = true;
            lbl_blackcurrants.Visible = true;
            lbl_plum.Visible = true;
            lbl_litchi.Visible = true;
            lbl_pineapple.Visible = true;
            lbl_mango.Visible = true;
            lbl_orange.Visible = true;
            lbl_peach.Visible = true;
            lbl_musk.Visible = true;
            lbl_avocado.Visible = true;
            lbl_dry.Visible = true;

            lbl_cal_apple.Visible = true;
            lbl_cal_watermelon.Visible = true;
            lbl_cal_strawberry.Visible = true;
            lbl_cal_banana.Visible = true;
            lbl_cal_cherries.Visible = true;
            lbl_cal_grapes.Visible = true;
            lbl_cal_pomegranate.Visible = true;
            lbl_cal_pear.Visible = true;
            lbl_cal_guava.Visible = true;
            lbl_cal_blackcurrants.Visible = true;
            lbl_cal_plum.Visible = true;
            lbl_cal_litchi.Visible = true;
            lbl_cal_pineapple.Visible = true;
            lbl_cal_mango.Visible = true;
            lbl_cal_orange.Visible = true;
            lbl_cal_peach.Visible = true;
            lbl_cal_musk.Visible = true;
            lbl_cal_avocado.Visible = true;
            lbl_cal_dry.Visible = true;

            txtbox_apple.Visible = true;
            txtbox_watermelon.Visible = true;
            txtbox_strawberry.Visible = true;
            txtbox_banana.Visible = true;
            txtbox_cherries.Visible = true;
            txtbox_grapes.Visible = true;
            txtbox_pomegranate.Visible = true;
            txtbox_pear.Visible = true;
            txtbox_guava.Visible = true;
            txtbox_blackcurrants.Visible = true;
            txtbox_plum.Visible = true;
            txtbox_litchi.Visible = true;
            txtbox_pineapple.Visible = true;
            txtbox_mango.Visible = true;
            txtbox_orange.Visible = true;
            txtbox_peach.Visible = true;
            txtbox_musk.Visible = true;
            txtbox_avocado.Visible = true;
            txtbox_dry.Visible = true;

            // SPICES AND CONDIMENTS //

            lbl_turmeric.Visible = false;
            lbl_black_pepper.Visible = false;
            lbl_fenugeek_seeds.Visible = false;
            lbl_kalonji.Visible = false;
            lbl_cumin.Visible = false;
            lbl_cloves.Visible = false;
            lbl_red_chillies.Visible = false;
            lbl_green_cardamom.Visible = false;
            lbl_poppy.Visible = false;
            lbl_asafoetida.Visible = false;
            lbl_mint.Visible = false;
            lbl_ginger.Visible = false;
            lbl_garlic.Visible = false;
            lbl_curry.Visible = false;
            lbl_nutmeg.Visible = false;
            lbl_coriander.Visible = false;
            lbl_green_chillies.Visible = false;
            lbl_dry_coconut.Visible = false;

            lbl_cal_turmeric.Visible = false;
            lbl_cal_black_pepper.Visible = false;
            lbl_cal_fenugeek_seeds.Visible = false;
            lbl_cal_kalonji.Visible = false;
            lbl_cal_cumin.Visible = false;
            lbl_cal_cloves.Visible = false;
            lbl_cal_red_chillies.Visible = false;
            lbl_cal_green_cardamom.Visible = false;
            lbl_cal_poppy.Visible = false;
            lbl_cal_asafoetida.Visible = false;
            lbl_cal_mint.Visible = false;
            lbl_cal_ginger.Visible = false;
            lbl_cal_garlic.Visible = false;
            lbl_cal_curry.Visible = false;
            lbl_cal_nutmeg.Visible = false;
            lbl_cal_coriander.Visible = false;
            lbl_cal_green_chillies.Visible = false;
            lbl_cal_dry_coconut.Visible = false;

            txtbox_turmeric.Visible = false;
            txtbox_black_pepper.Visible = false;
            txtbox_fenugeek_seeds.Visible = false;
            txtbox_kalonji.Visible = false;
            txtbox_cumin.Visible = false;
            txtbox_cloves.Visible = false;
            txtbox_red_chillies.Visible = false;
            txtbox_green_cardamom.Visible = false;
            txtbox_poppy.Visible = false;
            txtbox_asafoetida.Visible = false;
            txtbox_mint.Visible = false;
            txtbox_ginger.Visible = false;
            txtbox_garlic.Visible = false;
            txtbox_curry.Visible = false;
            txtbox_nutmeg.Visible = false;
            txtbox_coriander.Visible = false;
            txtbox_green_chillies.Visible = false;
            txtbox_dry_coconut.Visible = false;

            // NON-VEG FOODS //

            lbl_egg_white.Visible = false;
            lbl_egg_yolk.Visible = false;
            lbl_chicken_leg.Visible = false;
            lbl_chicken_thigh.Visible = false;
            lbl_chicken_breast.Visible = false;
            lbl_chicken_liver.Visible = false;
            lbl_pork.Visible = false;
            lbl_sheep.Visible = false;
            lbl_pomfret.Visible = false;
            lbl_tuna.Visible = false;
            lbl_salmon.Visible = false;
            lbl_crab.Visible = false;
            lbl_oyster.Visible = false;

            lbl_cal_egg_white.Visible = false;
            lbl_cal_egg_yolk.Visible = false;
            lbl_cal_chicken_leg.Visible = false;
            lbl_cal_chicken_thigh.Visible = false;
            lbl_cal_chicken_breast.Visible = false;
            lbl_cal_chicken_liver.Visible = false;
            lbl_cal_pork.Visible = false;
            lbl_cal_sheep.Visible = false;
            lbl_cal_pomfret.Visible = false;
            lbl_cal_tuna.Visible = false;
            lbl_cal_salmon.Visible = false;
            lbl_cal_crab.Visible = false;
            lbl_cal_oyster.Visible = false;

            txtbox_egg_white.Visible = false;
            txtbox_egg_yolk.Visible = false;
            txtbox_chicken_leg.Visible = false;
            txtbox_chicken_thigh.Visible = false;
            txtbox_chicken_breast.Visible = false;
            txtbox_chicken_liver.Visible = false;
            txtbox_pork.Visible = false;
            txtbox_sheep.Visible = false;
            txtbox_pomfret.Visible = false;
            txtbox_tuna.Visible = false;
            txtbox_salmon.Visible = false;
            txtbox_crab.Visible = false;
            txtbox_oyster.Visible = false;

            // NUTS AND SEEDS //

            lbl_almond.Visible = false;
            lbl_cashew.Visible = false;
            lbl_ground.Visible = false;
            lbl_linseeds.Visible = false;
            lbl_pine.Visible = false;
            lbl_pistachio.Visible = false;
            lbl_sunflower.Visible = false;
            lbl_walnut.Visible = false;
            lbl_flax.Visible = false;
            lbl_chia.Visible = false;

            lbl_cal_almond.Visible = false;
            lbl_cal_cashew.Visible = false;
            lbl_cal_ground.Visible = false;
            lbl_cal_linseeds.Visible = false;
            lbl_cal_pine.Visible = false;
            lbl_cal_pistachio.Visible = false;
            lbl_cal_sunflower.Visible = false;
            lbl_cal_walnut.Visible = false;
            lbl_cal_flax.Visible = false;
            lbl_cal_chia.Visible = false;

            txtbox_almond.Visible = false;
            txtbox_cashew.Visible = false;
            txtbox_ground.Visible = false;
            txtbox_linseeds.Visible = false;
            txtbox_pine.Visible = false;
            txtbox_pistachio.Visible = false;
            txtbox_sunflower.Visible = false;
            txtbox_walnut.Visible = false;
            txtbox_flax.Visible = false;
            txtbox_chia.Visible = false;

            // MILK PRODUCTS //

            lbl_buffalo.Visible = false;
            lbl_cow.Visible = false;
            lbl_soy.Visible = false;
            lbl_tofu.Visible = false;
            lbl_paneer.Visible = false;
            lbl_cheese.Visible = false;
            lbl_khoa.Visible = false;

            lbl_cal_buffalo.Visible = false;
            lbl_cal_cow.Visible = false;
            lbl_cal_soy.Visible = false;
            lbl_cal_tofu.Visible = false;
            lbl_cal_paneer.Visible = false;
            lbl_cal_cheese.Visible = false;
            lbl_cal_khoa.Visible = false;

            txtbox_buffalo.Visible = false;
            txtbox_cow.Visible = false;
            txtbox_soy.Visible = false;
            txtbox_tofu.Visible = false;
            txtbox_paneer.Visible = false;
            txtbox_cheese.Visible = false;
            txtbox_khoa.Visible = false;
        }

        private void btn_spices_Click(object sender, EventArgs e)
        {
            //  BUTTONS //

            btn_add.Visible = false;
            btn_add1.Visible = false;
            btn_add2.Visible = false;
            btn_add3.Visible = false;
            btn_add4.Visible = true;
            btn_add5.Visible = false;
            btn_add6.Visible = false;
            btn_add7.Visible = false;

            // CEREALS //

            lbl_barley.Visible = false;
            lbl_refined_flour.Visible = false;
            lbl_rice.Visible = false;
            lbl_rice_flakes.Visible = false;
            lbl_wheat_flour.Visible = false;
            lbl_bajra.Visible = false;
            lbl_jowar.Visible = false;
            lbl_quinoa.Visible = false;
            lbl_ragi.Visible = false;
            lbl_semolina.Visible = false;
            lbl_vermicelli.Visible = false;

            lbl_cal_barley.Visible = false;
            lbl_cal_refined_flour.Visible = false;
            lbl_cal_rice.Visible = false;
            lbl_cal_rice_flakes.Visible = false;
            lbl_cal_wheat_flour.Visible = false;
            lbl_cal_bajra.Visible = false;
            lbl_cal_jowar.Visible = false;
            lbl_cal_quinoa.Visible = false;
            lbl_cal_ragi.Visible = false;
            lbl_cal_semolina.Visible = false;
            lbl_cal_vermicelli.Visible = false;

            txtbox_barley.Visible = false;
            txtbox_refined_flour.Visible = false;
            txtbox_rice.Visible = false;
            txtbox_rice_flakes.Visible = false;
            txtbox_wheat_flour.Visible = false;
            txtbox_bajra.Visible = false; ;
            txtbox_jowar.Visible = false;
            txtbox_quinoa.Visible = false;
            txtbox_ragi.Visible = false;
            txtbox_semolina.Visible = false;
            txtbox_vermicelli.Visible = false;

            //  VEGETABLES //

            lbl_bottle.Visible = false;
            lbl_bitter.Visible = false;
            lbl_brinjal.Visible = false;
            lbl_capsicum.Visible = false;
            lbl_cauliflower.Visible = false;
            lbl_cucumber.Visible = false;
            lbl_french.Visible = false;
            lbl_lady.Visible = false;
            lbl_peas.Visible = false;
            lbl_pumpkin.Visible = false;
            lbl_tomato.Visible = false;
            lbl_beetroot.Visible = false;
            lbl_carrot.Visible = false;
            lbl_potato.Visible = false;
            lbl_radish.Visible = false;
            lbl_sweet.Visible = false;
            lbl_ash.Visible = false;

            lbl_cal_bottle.Visible = false;
            lbl_cal_bitter.Visible = false;
            lbl_cal_brinjal.Visible = false;
            lbl_cal_capsicum.Visible = false;
            lbl_cal_cauliflower.Visible = false;
            lbl_cal_cucumber.Visible = false;
            lbl_cal_french.Visible = false;
            lbl_cal_lady.Visible = false;
            lbl_cal_peas.Visible = false;
            lbl_cal_pumpkin.Visible = false;
            lbl_cal_tomato.Visible = false;
            lbl_cal_beetroot.Visible = false;
            lbl_cal_carrot.Visible = false;
            lbl_cal_potato.Visible = false;
            lbl_cal_radish.Visible = false;
            lbl_cal_sweet.Visible = false;
            lbl_cal_ash.Visible = false;

            txtbox_bottle.Visible = false;
            txtbox_bitter.Visible = false;
            txtbox_brinjal.Visible = false;
            txtbox_capsicum.Visible = false;
            txtbox_cauliflower.Visible = false;
            txtbox_cucumber.Visible = false;
            txtbox_french.Visible = false;
            txtbox_lady.Visible = false;
            txtbox_peas.Visible = false;
            txtbox_pumpkin.Visible = false;
            txtbox_tomato.Visible = false;
            txtbox_beetroot.Visible = false;
            txtbox_carrot.Visible = false;
            txtbox_potato.Visible = false;
            txtbox_radish.Visible = false;
            txtbox_sweet.Visible = false;
            txtbox_ash.Visible = false;

            // GREEN-LEAFY VEGETABLES //

            lbl_spinach.Visible = false;
            lbl_radish_leaves.Visible = false;
            lbl_parsley.Visible = false;
            lbl_lettuce.Visible = false;
            lbl_cauliflower_leaves.Visible = false;
            lbl_cabbage.Visible = false;
            lbl_brussel.Visible = false;
            lbl_fenugreek.Visible = false;
            lbl_beet.Visible = false;
            lbl_drumstick.Visible = false;

            lbl_cal_spinach.Visible = false;
            lbl_cal_radish_leaves.Visible = false;
            lbl_cal_parsley.Visible = false;
            lbl_cal_lettuce.Visible = false;
            lbl_cal_cauliflower_leaves.Visible = false;
            lbl_cal_cabbage.Visible = false;
            lbl_cal_brussel.Visible = false;
            lbl_cal_fenugreek.Visible = false;
            lbl_cal_beet.Visible = false;
            lbl_cal_drumstick.Visible = false;

            txtbox_spinach.Visible = false;
            txtbox_radish_leaves.Visible = false;
            txtbox_parsley.Visible = false;
            txtbox_lettuce.Visible = false;
            txtbox_cauliflower_leaves.Visible = false;
            txtbox_cabbage.Visible = false;
            txtbox_brussel.Visible = false;
            txtbox_fenugreek.Visible = false;
            txtbox_beet.Visible = false;
            txtbox_drumstick.Visible = false;

            // FRUITS //

            lbl_apple.Visible = false;
            lbl_watermelon.Visible = false;
            lbl_strawberry.Visible = false;
            lbl_banana.Visible = false;
            lbl_cherries.Visible = false;
            lbl_grapes.Visible = false;
            lbl_pomegranate.Visible = false;
            lbl_pear.Visible = false;
            lbl_guava.Visible = false;
            lbl_blackcurrants.Visible = false;
            lbl_plum.Visible = false;
            lbl_litchi.Visible = false;
            lbl_pineapple.Visible = false;
            lbl_mango.Visible = false;
            lbl_orange.Visible = false;
            lbl_peach.Visible = false;
            lbl_musk.Visible = false;
            lbl_avocado.Visible = false;
            lbl_dry.Visible = false;

            lbl_cal_apple.Visible = false;
            lbl_cal_watermelon.Visible = false;
            lbl_cal_strawberry.Visible = false;
            lbl_cal_banana.Visible = false;
            lbl_cal_cherries.Visible = false;
            lbl_cal_grapes.Visible = false;
            lbl_cal_pomegranate.Visible = false;
            lbl_cal_pear.Visible = false;
            lbl_cal_guava.Visible = false;
            lbl_cal_blackcurrants.Visible = false;
            lbl_cal_plum.Visible = false;
            lbl_cal_litchi.Visible = false;
            lbl_cal_pineapple.Visible = false;
            lbl_cal_mango.Visible = false;
            lbl_cal_orange.Visible = false;
            lbl_cal_peach.Visible = false;
            lbl_cal_musk.Visible = false;
            lbl_cal_avocado.Visible = false;
            lbl_cal_dry.Visible = false;

            txtbox_apple.Visible = false;
            txtbox_watermelon.Visible = false;
            txtbox_strawberry.Visible = false;
            txtbox_banana.Visible = false;
            txtbox_cherries.Visible = false;
            txtbox_grapes.Visible = false;
            txtbox_pomegranate.Visible = false;
            txtbox_pear.Visible = false;
            txtbox_guava.Visible = false;
            txtbox_blackcurrants.Visible = false;
            txtbox_plum.Visible = false;
            txtbox_litchi.Visible = false;
            txtbox_pineapple.Visible = false;
            txtbox_mango.Visible = false;
            txtbox_orange.Visible = false;
            txtbox_peach.Visible = false;
            txtbox_musk.Visible = false;
            txtbox_avocado.Visible = false;
            txtbox_dry.Visible = false;

            // SPICES AND CONDIMENTS //

            lbl_turmeric.Visible = true;
            lbl_black_pepper.Visible = true;
            lbl_fenugeek_seeds.Visible = true;
            lbl_kalonji.Visible = true;
            lbl_cumin.Visible = true;
            lbl_cloves.Visible = true;
            lbl_red_chillies.Visible = true;
            lbl_green_cardamom.Visible = true;
            lbl_poppy.Visible = true;
            lbl_asafoetida.Visible = true;
            lbl_mint.Visible = true;
            lbl_ginger.Visible = true;
            lbl_garlic.Visible = true;
            lbl_curry.Visible = true;
            lbl_nutmeg.Visible = true;
            lbl_coriander.Visible = true;
            lbl_green_chillies.Visible = true;
            lbl_dry_coconut.Visible = true;

            lbl_cal_turmeric.Visible = true;
            lbl_cal_black_pepper.Visible = true;
            lbl_cal_fenugeek_seeds.Visible = true;
            lbl_cal_kalonji.Visible = true;
            lbl_cal_cumin.Visible = true;
            lbl_cal_cloves.Visible = true;
            lbl_cal_red_chillies.Visible = true;
            lbl_cal_green_cardamom.Visible = true;
            lbl_cal_poppy.Visible = true;
            lbl_cal_asafoetida.Visible = true;
            lbl_cal_mint.Visible = true;
            lbl_cal_ginger.Visible = true;
            lbl_cal_garlic.Visible = true;
            lbl_cal_curry.Visible = true;
            lbl_cal_nutmeg.Visible = true;
            lbl_cal_coriander.Visible = true;
            lbl_cal_green_chillies.Visible = true;
            lbl_cal_dry_coconut.Visible = true;

            txtbox_turmeric.Visible = true;
            txtbox_black_pepper.Visible = true;
            txtbox_fenugeek_seeds.Visible = true;
            txtbox_kalonji.Visible = true;
            txtbox_cumin.Visible = true;
            txtbox_cloves.Visible = true;
            txtbox_red_chillies.Visible = true;
            txtbox_green_cardamom.Visible = true;
            txtbox_poppy.Visible = true;
            txtbox_asafoetida.Visible = true;
            txtbox_mint.Visible = true;
            txtbox_ginger.Visible = true;
            txtbox_garlic.Visible = true;
            txtbox_curry.Visible = true;
            txtbox_nutmeg.Visible = true;
            txtbox_coriander.Visible = true;
            txtbox_green_chillies.Visible = true;
            txtbox_dry_coconut.Visible = true;

            // NON-VEG FOODS //

            lbl_egg_white.Visible = false;
            lbl_egg_yolk.Visible = false;
            lbl_chicken_leg.Visible = false;
            lbl_chicken_thigh.Visible = false;
            lbl_chicken_breast.Visible = false;
            lbl_chicken_liver.Visible = false;
            lbl_pork.Visible = false;
            lbl_sheep.Visible = false;
            lbl_pomfret.Visible = false;
            lbl_tuna.Visible = false;
            lbl_salmon.Visible = false;
            lbl_crab.Visible = false;
            lbl_oyster.Visible = false;

            lbl_cal_egg_white.Visible = false;
            lbl_cal_egg_yolk.Visible = false;
            lbl_cal_chicken_leg.Visible = false;
            lbl_cal_chicken_thigh.Visible = false;
            lbl_cal_chicken_breast.Visible = false;
            lbl_cal_chicken_liver.Visible = false;
            lbl_cal_pork.Visible = false;
            lbl_cal_sheep.Visible = false;
            lbl_cal_pomfret.Visible = false;
            lbl_cal_tuna.Visible = false;
            lbl_cal_salmon.Visible = false;
            lbl_cal_crab.Visible = false;
            lbl_cal_oyster.Visible = false;

            txtbox_egg_white.Visible = false;
            txtbox_egg_yolk.Visible = false;
            txtbox_chicken_leg.Visible = false;
            txtbox_chicken_thigh.Visible = false;
            txtbox_chicken_breast.Visible = false;
            txtbox_chicken_liver.Visible = false;
            txtbox_pork.Visible = false;
            txtbox_sheep.Visible = false;
            txtbox_pomfret.Visible = false;
            txtbox_tuna.Visible = false;
            txtbox_salmon.Visible = false;
            txtbox_crab.Visible = false;
            txtbox_oyster.Visible = false;

            // NUTS AND SEEDS //

            lbl_almond.Visible = false;
            lbl_cashew.Visible = false;
            lbl_ground.Visible = false;
            lbl_linseeds.Visible = false;
            lbl_pine.Visible = false;
            lbl_pistachio.Visible = false;
            lbl_sunflower.Visible = false;
            lbl_walnut.Visible = false;
            lbl_flax.Visible = false;
            lbl_chia.Visible = false;

            lbl_cal_almond.Visible = false;
            lbl_cal_cashew.Visible = false;
            lbl_cal_ground.Visible = false;
            lbl_cal_linseeds.Visible = false;
            lbl_cal_pine.Visible = false;
            lbl_cal_pistachio.Visible = false;
            lbl_cal_sunflower.Visible = false;
            lbl_cal_walnut.Visible = false;
            lbl_cal_flax.Visible = false;
            lbl_cal_chia.Visible = false;

            txtbox_almond.Visible = false;
            txtbox_cashew.Visible = false;
            txtbox_ground.Visible = false;
            txtbox_linseeds.Visible = false;
            txtbox_pine.Visible = false;
            txtbox_pistachio.Visible = false;
            txtbox_sunflower.Visible = false;
            txtbox_walnut.Visible = false;
            txtbox_flax.Visible = false;
            txtbox_chia.Visible = false;

            // MILK PRODUCTS //

            lbl_buffalo.Visible = false;
            lbl_cow.Visible = false;
            lbl_soy.Visible = false;
            lbl_tofu.Visible = false;
            lbl_paneer.Visible = false;
            lbl_cheese.Visible = false;
            lbl_khoa.Visible = false;

            lbl_cal_buffalo.Visible = false;
            lbl_cal_cow.Visible = false;
            lbl_cal_soy.Visible = false;
            lbl_cal_tofu.Visible = false;
            lbl_cal_paneer.Visible = false;
            lbl_cal_cheese.Visible = false;
            lbl_cal_khoa.Visible = false;

            txtbox_buffalo.Visible = false;
            txtbox_cow.Visible = false;
            txtbox_soy.Visible = false;
            txtbox_tofu.Visible = false;
            txtbox_paneer.Visible = false;
            txtbox_cheese.Visible = false;
            txtbox_khoa.Visible = false;
        }

        private void btn_nonveg_Click(object sender, EventArgs e)
        {
            //  BUTTONS //

            btn_add.Visible = false;
            btn_add1.Visible = false;
            btn_add2.Visible = false;
            btn_add3.Visible = false;
            btn_add4.Visible = false;
            btn_add5.Visible = true;
            btn_add6.Visible = false;
            btn_add7.Visible = false;

            // CEREALS //

            lbl_barley.Visible = false;
            lbl_refined_flour.Visible = false;
            lbl_rice.Visible = false;
            lbl_rice_flakes.Visible = false;
            lbl_wheat_flour.Visible = false;
            lbl_bajra.Visible = false;
            lbl_jowar.Visible = false;
            lbl_quinoa.Visible = false;
            lbl_ragi.Visible = false;
            lbl_semolina.Visible = false;
            lbl_vermicelli.Visible = false;

            lbl_cal_barley.Visible = false;
            lbl_cal_refined_flour.Visible = false;
            lbl_cal_rice.Visible = false;
            lbl_cal_rice_flakes.Visible = false;
            lbl_cal_wheat_flour.Visible = false;
            lbl_cal_bajra.Visible = false;
            lbl_cal_jowar.Visible = false;
            lbl_cal_quinoa.Visible = false;
            lbl_cal_ragi.Visible = false;
            lbl_cal_semolina.Visible = false;
            lbl_cal_vermicelli.Visible = false;

            txtbox_barley.Visible = false;
            txtbox_refined_flour.Visible = false;
            txtbox_rice.Visible = false;
            txtbox_rice_flakes.Visible = false;
            txtbox_wheat_flour.Visible = false;
            txtbox_bajra.Visible = false; ;
            txtbox_jowar.Visible = false;
            txtbox_quinoa.Visible = false;
            txtbox_ragi.Visible = false;
            txtbox_semolina.Visible = false;
            txtbox_vermicelli.Visible = false;

            //  VEGETABLES //

            lbl_bottle.Visible = false;
            lbl_bitter.Visible = false;
            lbl_brinjal.Visible = false;
            lbl_capsicum.Visible = false;
            lbl_cauliflower.Visible = false;
            lbl_cucumber.Visible = false;
            lbl_french.Visible = false;
            lbl_lady.Visible = false;
            lbl_peas.Visible = false;
            lbl_pumpkin.Visible = false;
            lbl_tomato.Visible = false;
            lbl_beetroot.Visible = false;
            lbl_carrot.Visible = false;
            lbl_potato.Visible = false;
            lbl_radish.Visible = false;
            lbl_sweet.Visible = false;
            lbl_ash.Visible = false;

            lbl_cal_bottle.Visible = false;
            lbl_cal_bitter.Visible = false;
            lbl_cal_brinjal.Visible = false;
            lbl_cal_capsicum.Visible = false;
            lbl_cal_cauliflower.Visible = false;
            lbl_cal_cucumber.Visible = false;
            lbl_cal_french.Visible = false;
            lbl_cal_lady.Visible = false;
            lbl_cal_peas.Visible = false;
            lbl_cal_pumpkin.Visible = false;
            lbl_cal_tomato.Visible = false;
            lbl_cal_beetroot.Visible = false;
            lbl_cal_carrot.Visible = false;
            lbl_cal_potato.Visible = false;
            lbl_cal_radish.Visible = false;
            lbl_cal_sweet.Visible = false;
            lbl_cal_ash.Visible = false;

            txtbox_bottle.Visible = false;
            txtbox_bitter.Visible = false;
            txtbox_brinjal.Visible = false;
            txtbox_capsicum.Visible = false;
            txtbox_cauliflower.Visible = false;
            txtbox_cucumber.Visible = false;
            txtbox_french.Visible = false;
            txtbox_lady.Visible = false;
            txtbox_peas.Visible = false;
            txtbox_pumpkin.Visible = false;
            txtbox_tomato.Visible = false;
            txtbox_beetroot.Visible = false;
            txtbox_carrot.Visible = false;
            txtbox_potato.Visible = false;
            txtbox_radish.Visible = false;
            txtbox_sweet.Visible = false;
            txtbox_ash.Visible = false;

            // GREEN-LEAFY VEGETABLES //

            lbl_spinach.Visible = false;
            lbl_radish_leaves.Visible = false;
            lbl_parsley.Visible = false;
            lbl_lettuce.Visible = false;
            lbl_cauliflower_leaves.Visible = false;
            lbl_cabbage.Visible = false;
            lbl_brussel.Visible = false;
            lbl_fenugreek.Visible = false;
            lbl_beet.Visible = false;
            lbl_drumstick.Visible = false;

            lbl_cal_spinach.Visible = false;
            lbl_cal_radish_leaves.Visible = false;
            lbl_cal_parsley.Visible = false;
            lbl_cal_lettuce.Visible = false;
            lbl_cal_cauliflower_leaves.Visible = false;
            lbl_cal_cabbage.Visible = false;
            lbl_cal_brussel.Visible = false;
            lbl_cal_fenugreek.Visible = false;
            lbl_cal_beet.Visible = false;
            lbl_cal_drumstick.Visible = false;

            txtbox_spinach.Visible = false;
            txtbox_radish_leaves.Visible = false;
            txtbox_parsley.Visible = false;
            txtbox_lettuce.Visible = false;
            txtbox_cauliflower_leaves.Visible = false;
            txtbox_cabbage.Visible = false;
            txtbox_brussel.Visible = false;
            txtbox_fenugreek.Visible = false;
            txtbox_beet.Visible = false;
            txtbox_drumstick.Visible = false;

            // FRUITS //

            lbl_apple.Visible = false;
            lbl_watermelon.Visible = false;
            lbl_strawberry.Visible = false;
            lbl_banana.Visible = false;
            lbl_cherries.Visible = false;
            lbl_grapes.Visible = false;
            lbl_pomegranate.Visible = false;
            lbl_pear.Visible = false;
            lbl_guava.Visible = false;
            lbl_blackcurrants.Visible = false;
            lbl_plum.Visible = false;
            lbl_litchi.Visible = false;
            lbl_pineapple.Visible = false;
            lbl_mango.Visible = false;
            lbl_orange.Visible = false;
            lbl_peach.Visible = false;
            lbl_musk.Visible = false;
            lbl_avocado.Visible = false;
            lbl_dry.Visible = false;

            lbl_cal_apple.Visible = false;
            lbl_cal_watermelon.Visible = false;
            lbl_cal_strawberry.Visible = false;
            lbl_cal_banana.Visible = false;
            lbl_cal_cherries.Visible = false;
            lbl_cal_grapes.Visible = false;
            lbl_cal_pomegranate.Visible = false;
            lbl_cal_pear.Visible = false;
            lbl_cal_guava.Visible = false;
            lbl_cal_blackcurrants.Visible = false;
            lbl_cal_plum.Visible = false;
            lbl_cal_litchi.Visible = false;
            lbl_cal_pineapple.Visible = false;
            lbl_cal_mango.Visible = false;
            lbl_cal_orange.Visible = false;
            lbl_cal_peach.Visible = false;
            lbl_cal_musk.Visible = false;
            lbl_cal_avocado.Visible = false;
            lbl_cal_dry.Visible = false;

            txtbox_apple.Visible = false;
            txtbox_watermelon.Visible = false;
            txtbox_strawberry.Visible = false;
            txtbox_banana.Visible = false;
            txtbox_cherries.Visible = false;
            txtbox_grapes.Visible = false;
            txtbox_pomegranate.Visible = false;
            txtbox_pear.Visible = false;
            txtbox_guava.Visible = false;
            txtbox_blackcurrants.Visible = false;
            txtbox_plum.Visible = false;
            txtbox_litchi.Visible = false;
            txtbox_pineapple.Visible = false;
            txtbox_mango.Visible = false;
            txtbox_orange.Visible = false;
            txtbox_peach.Visible = false;
            txtbox_musk.Visible = false;
            txtbox_avocado.Visible = false;
            txtbox_dry.Visible = false;

            // SPICES AND CONDIMENTS //

            lbl_turmeric.Visible = false;
            lbl_black_pepper.Visible = false;
            lbl_fenugeek_seeds.Visible = false;
            lbl_kalonji.Visible = false;
            lbl_cumin.Visible = false;
            lbl_cloves.Visible = false;
            lbl_red_chillies.Visible = false;
            lbl_green_cardamom.Visible = false;
            lbl_poppy.Visible = false;
            lbl_asafoetida.Visible = false;
            lbl_mint.Visible = false;
            lbl_ginger.Visible = false;
            lbl_garlic.Visible = false;
            lbl_curry.Visible = false;
            lbl_nutmeg.Visible = false;
            lbl_coriander.Visible = false;
            lbl_green_chillies.Visible = false;
            lbl_dry_coconut.Visible = false;

            lbl_cal_turmeric.Visible = false;
            lbl_cal_black_pepper.Visible = false;
            lbl_cal_fenugeek_seeds.Visible = false;
            lbl_cal_kalonji.Visible = false;
            lbl_cal_cumin.Visible = false;
            lbl_cal_cloves.Visible = false;
            lbl_cal_red_chillies.Visible = false;
            lbl_cal_green_cardamom.Visible = false;
            lbl_cal_poppy.Visible = false;
            lbl_cal_asafoetida.Visible = false;
            lbl_cal_mint.Visible = false;
            lbl_cal_ginger.Visible = false;
            lbl_cal_garlic.Visible = false;
            lbl_cal_curry.Visible = false;
            lbl_cal_nutmeg.Visible = false;
            lbl_cal_coriander.Visible = false;
            lbl_cal_green_chillies.Visible = false;
            lbl_cal_dry_coconut.Visible = false;

            txtbox_turmeric.Visible = false;
            txtbox_black_pepper.Visible = false;
            txtbox_fenugeek_seeds.Visible = false;
            txtbox_kalonji.Visible = false;
            txtbox_cumin.Visible = false;
            txtbox_cloves.Visible = false;
            txtbox_red_chillies.Visible = false;
            txtbox_green_cardamom.Visible = false;
            txtbox_poppy.Visible = false;
            txtbox_asafoetida.Visible = false;
            txtbox_mint.Visible = false;
            txtbox_ginger.Visible = false;
            txtbox_garlic.Visible = false;
            txtbox_curry.Visible = false;
            txtbox_nutmeg.Visible = false;
            txtbox_coriander.Visible = false;
            txtbox_green_chillies.Visible = false;
            txtbox_dry_coconut.Visible = false;

            // NON-VEG FOODS //

            lbl_egg_white.Visible = true;
            lbl_egg_yolk.Visible = true;
            lbl_chicken_leg.Visible = true;
            lbl_chicken_thigh.Visible = true;
            lbl_chicken_breast.Visible = true;
            lbl_chicken_liver.Visible = true;
            lbl_pork.Visible = true;
            lbl_sheep.Visible = true;
            lbl_pomfret.Visible = true;
            lbl_tuna.Visible = true;
            lbl_salmon.Visible = true;
            lbl_crab.Visible = true;
            lbl_oyster.Visible = true;

            lbl_cal_egg_white.Visible = true;
            lbl_cal_egg_yolk.Visible = true;
            lbl_cal_chicken_leg.Visible = true;
            lbl_cal_chicken_thigh.Visible = true;
            lbl_cal_chicken_breast.Visible = true;
            lbl_cal_chicken_liver.Visible = true;
            lbl_cal_pork.Visible = true;
            lbl_cal_sheep.Visible = true;
            lbl_cal_pomfret.Visible = true;
            lbl_cal_tuna.Visible = true;
            lbl_cal_salmon.Visible = true;
            lbl_cal_crab.Visible = true;
            lbl_cal_oyster.Visible = true;

            txtbox_egg_white.Visible = true;
            txtbox_egg_yolk.Visible = true;
            txtbox_chicken_leg.Visible = true;
            txtbox_chicken_thigh.Visible = true;
            txtbox_chicken_breast.Visible = true;
            txtbox_chicken_liver.Visible = true;
            txtbox_pork.Visible = true;
            txtbox_sheep.Visible = true;
            txtbox_pomfret.Visible = true;
            txtbox_tuna.Visible = true;
            txtbox_salmon.Visible = true;
            txtbox_crab.Visible = true;
            txtbox_oyster.Visible = true;

            // NUTS AND SEEDS //

            lbl_almond.Visible = false;
            lbl_cashew.Visible = false;
            lbl_ground.Visible = false;
            lbl_linseeds.Visible = false;
            lbl_pine.Visible = false;
            lbl_pistachio.Visible = false;
            lbl_sunflower.Visible = false;
            lbl_walnut.Visible = false;
            lbl_flax.Visible = false;
            lbl_chia.Visible = false;

            lbl_cal_almond.Visible = false;
            lbl_cal_cashew.Visible = false;
            lbl_cal_ground.Visible = false;
            lbl_cal_linseeds.Visible = false;
            lbl_cal_pine.Visible = false;
            lbl_cal_pistachio.Visible = false;
            lbl_cal_sunflower.Visible = false;
            lbl_cal_walnut.Visible = false;
            lbl_cal_flax.Visible = false;
            lbl_cal_chia.Visible = false;

            txtbox_almond.Visible = false;
            txtbox_cashew.Visible = false;
            txtbox_ground.Visible = false;
            txtbox_linseeds.Visible = false;
            txtbox_pine.Visible = false;
            txtbox_pistachio.Visible = false;
            txtbox_sunflower.Visible = false;
            txtbox_walnut.Visible = false;
            txtbox_flax.Visible = false;
            txtbox_chia.Visible = false;

            // MILK PRODUCTS //

            lbl_buffalo.Visible = false;
            lbl_cow.Visible = false;
            lbl_soy.Visible = false;
            lbl_tofu.Visible = false;
            lbl_paneer.Visible = false;
            lbl_cheese.Visible = false;
            lbl_khoa.Visible = false;

            lbl_cal_buffalo.Visible = false;
            lbl_cal_cow.Visible = false;
            lbl_cal_soy.Visible = false;
            lbl_cal_tofu.Visible = false;
            lbl_cal_paneer.Visible = false;
            lbl_cal_cheese.Visible = false;
            lbl_cal_khoa.Visible = false;

            txtbox_buffalo.Visible = false;
            txtbox_cow.Visible = false;
            txtbox_soy.Visible = false;
            txtbox_tofu.Visible = false;
            txtbox_paneer.Visible = false;
            txtbox_cheese.Visible = false;
            txtbox_khoa.Visible = false;
        }

        private void btn_nuts_Click(object sender, EventArgs e)
        {
            //  BUTTONS //

            btn_add.Visible = false;
            btn_add1.Visible = false;
            btn_add2.Visible = false;
            btn_add3.Visible = false;
            btn_add4.Visible = false;
            btn_add5.Visible = false;
            btn_add6.Visible = true;
            btn_add7.Visible = false;

            // CEREALS //

            lbl_barley.Visible = false;
            lbl_refined_flour.Visible = false;
            lbl_rice.Visible = false;
            lbl_rice_flakes.Visible = false;
            lbl_wheat_flour.Visible = false;
            lbl_bajra.Visible = false;
            lbl_jowar.Visible = false;
            lbl_quinoa.Visible = false;
            lbl_ragi.Visible = false;
            lbl_semolina.Visible = false;
            lbl_vermicelli.Visible = false;

            lbl_cal_barley.Visible = false;
            lbl_cal_refined_flour.Visible = false;
            lbl_cal_rice.Visible = false;
            lbl_cal_rice_flakes.Visible = false;
            lbl_cal_wheat_flour.Visible = false;
            lbl_cal_bajra.Visible = false;
            lbl_cal_jowar.Visible = false;
            lbl_cal_quinoa.Visible = false;
            lbl_cal_ragi.Visible = false;
            lbl_cal_semolina.Visible = false;
            lbl_cal_vermicelli.Visible = false;

            txtbox_barley.Visible = false;
            txtbox_refined_flour.Visible = false;
            txtbox_rice.Visible = false;
            txtbox_rice_flakes.Visible = false;
            txtbox_wheat_flour.Visible = false;
            txtbox_bajra.Visible = false; ;
            txtbox_jowar.Visible = false;
            txtbox_quinoa.Visible = false;
            txtbox_ragi.Visible = false;
            txtbox_semolina.Visible = false;
            txtbox_vermicelli.Visible = false;

            //  VEGETABLES //

            lbl_bottle.Visible = false;
            lbl_bitter.Visible = false;
            lbl_brinjal.Visible = false;
            lbl_capsicum.Visible = false;
            lbl_cauliflower.Visible = false;
            lbl_cucumber.Visible = false;
            lbl_french.Visible = false;
            lbl_lady.Visible = false;
            lbl_peas.Visible = false;
            lbl_pumpkin.Visible = false;
            lbl_tomato.Visible = false;
            lbl_beetroot.Visible = false;
            lbl_carrot.Visible = false;
            lbl_potato.Visible = false;
            lbl_radish.Visible = false;
            lbl_sweet.Visible = false;
            lbl_ash.Visible = false;

            lbl_cal_bottle.Visible = false;
            lbl_cal_bitter.Visible = false;
            lbl_cal_brinjal.Visible = false;
            lbl_cal_capsicum.Visible = false;
            lbl_cal_cauliflower.Visible = false;
            lbl_cal_cucumber.Visible = false;
            lbl_cal_french.Visible = false;
            lbl_cal_lady.Visible = false;
            lbl_cal_peas.Visible = false;
            lbl_cal_pumpkin.Visible = false;
            lbl_cal_tomato.Visible = false;
            lbl_cal_beetroot.Visible = false;
            lbl_cal_carrot.Visible = false;
            lbl_cal_potato.Visible = false;
            lbl_cal_radish.Visible = false;
            lbl_cal_sweet.Visible = false;
            lbl_cal_ash.Visible = false;

            txtbox_bottle.Visible = false;
            txtbox_bitter.Visible = false;
            txtbox_brinjal.Visible = false;
            txtbox_capsicum.Visible = false;
            txtbox_cauliflower.Visible = false;
            txtbox_cucumber.Visible = false;
            txtbox_french.Visible = false;
            txtbox_lady.Visible = false;
            txtbox_peas.Visible = false;
            txtbox_pumpkin.Visible = false;
            txtbox_tomato.Visible = false;
            txtbox_beetroot.Visible = false;
            txtbox_carrot.Visible = false;
            txtbox_potato.Visible = false;
            txtbox_radish.Visible = false;
            txtbox_sweet.Visible = false;
            txtbox_ash.Visible = false;

            // GREEN-LEAFY VEGETABLES //

            lbl_spinach.Visible = false;
            lbl_radish_leaves.Visible = false;
            lbl_parsley.Visible = false;
            lbl_lettuce.Visible = false;
            lbl_cauliflower_leaves.Visible = false;
            lbl_cabbage.Visible = false;
            lbl_brussel.Visible = false;
            lbl_fenugreek.Visible = false;
            lbl_beet.Visible = false;
            lbl_drumstick.Visible = false;

            lbl_cal_spinach.Visible = false;
            lbl_cal_radish_leaves.Visible = false;
            lbl_cal_parsley.Visible = false;
            lbl_cal_lettuce.Visible = false;
            lbl_cal_cauliflower_leaves.Visible = false;
            lbl_cal_cabbage.Visible = false;
            lbl_cal_brussel.Visible = false;
            lbl_cal_fenugreek.Visible = false;
            lbl_cal_beet.Visible = false;
            lbl_cal_drumstick.Visible = false;

            txtbox_spinach.Visible = false;
            txtbox_radish_leaves.Visible = false;
            txtbox_parsley.Visible = false;
            txtbox_lettuce.Visible = false;
            txtbox_cauliflower_leaves.Visible = false;
            txtbox_cabbage.Visible = false;
            txtbox_brussel.Visible = false;
            txtbox_fenugreek.Visible = false;
            txtbox_beet.Visible = false;
            txtbox_drumstick.Visible = false;

            // FRUITS //

            lbl_apple.Visible = false;
            lbl_watermelon.Visible = false;
            lbl_strawberry.Visible = false;
            lbl_banana.Visible = false;
            lbl_cherries.Visible = false;
            lbl_grapes.Visible = false;
            lbl_pomegranate.Visible = false;
            lbl_pear.Visible = false;
            lbl_guava.Visible = false;
            lbl_blackcurrants.Visible = false;
            lbl_plum.Visible = false;
            lbl_litchi.Visible = false;
            lbl_pineapple.Visible = false;
            lbl_mango.Visible = false;
            lbl_orange.Visible = false;
            lbl_peach.Visible = false;
            lbl_musk.Visible = false;
            lbl_avocado.Visible = false;
            lbl_dry.Visible = false;

            lbl_cal_apple.Visible = false;
            lbl_cal_watermelon.Visible = false;
            lbl_cal_strawberry.Visible = false;
            lbl_cal_banana.Visible = false;
            lbl_cal_cherries.Visible = false;
            lbl_cal_grapes.Visible = false;
            lbl_cal_pomegranate.Visible = false;
            lbl_cal_pear.Visible = false;
            lbl_cal_guava.Visible = false;
            lbl_cal_blackcurrants.Visible = false;
            lbl_cal_plum.Visible = false;
            lbl_cal_litchi.Visible = false;
            lbl_cal_pineapple.Visible = false;
            lbl_cal_mango.Visible = false;
            lbl_cal_orange.Visible = false;
            lbl_cal_peach.Visible = false;
            lbl_cal_musk.Visible = false;
            lbl_cal_avocado.Visible = false;
            lbl_cal_dry.Visible = false;

            txtbox_apple.Visible = false;
            txtbox_watermelon.Visible = false;
            txtbox_strawberry.Visible = false;
            txtbox_banana.Visible = false;
            txtbox_cherries.Visible = false;
            txtbox_grapes.Visible = false;
            txtbox_pomegranate.Visible = false;
            txtbox_pear.Visible = false;
            txtbox_guava.Visible = false;
            txtbox_blackcurrants.Visible = false;
            txtbox_plum.Visible = false;
            txtbox_litchi.Visible = false;
            txtbox_pineapple.Visible = false;
            txtbox_mango.Visible = false;
            txtbox_orange.Visible = false;
            txtbox_peach.Visible = false;
            txtbox_musk.Visible = false;
            txtbox_avocado.Visible = false;
            txtbox_dry.Visible = false;

            // SPICES AND CONDIMENTS //

            lbl_turmeric.Visible = false;
            lbl_black_pepper.Visible = false;
            lbl_fenugeek_seeds.Visible = false;
            lbl_kalonji.Visible = false;
            lbl_cumin.Visible = false;
            lbl_cloves.Visible = false;
            lbl_red_chillies.Visible = false;
            lbl_green_cardamom.Visible = false;
            lbl_poppy.Visible = false;
            lbl_asafoetida.Visible = false;
            lbl_mint.Visible = false;
            lbl_ginger.Visible = false;
            lbl_garlic.Visible = false;
            lbl_curry.Visible = false;
            lbl_nutmeg.Visible = false;
            lbl_coriander.Visible = false;
            lbl_green_chillies.Visible = false;
            lbl_dry_coconut.Visible = false;

            lbl_cal_turmeric.Visible = false;
            lbl_cal_black_pepper.Visible = false;
            lbl_cal_fenugeek_seeds.Visible = false;
            lbl_cal_kalonji.Visible = false;
            lbl_cal_cumin.Visible = false;
            lbl_cal_cloves.Visible = false;
            lbl_cal_red_chillies.Visible = false;
            lbl_cal_green_cardamom.Visible = false;
            lbl_cal_poppy.Visible = false;
            lbl_cal_asafoetida.Visible = false;
            lbl_cal_mint.Visible = false;
            lbl_cal_ginger.Visible = false;
            lbl_cal_garlic.Visible = false;
            lbl_cal_curry.Visible = false;
            lbl_cal_nutmeg.Visible = false;
            lbl_cal_coriander.Visible = false;
            lbl_cal_green_chillies.Visible = false;
            lbl_cal_dry_coconut.Visible = false;

            txtbox_turmeric.Visible = false;
            txtbox_black_pepper.Visible = false;
            txtbox_fenugeek_seeds.Visible = false;
            txtbox_kalonji.Visible = false;
            txtbox_cumin.Visible = false;
            txtbox_cloves.Visible = false;
            txtbox_red_chillies.Visible = false;
            txtbox_green_cardamom.Visible = false;
            txtbox_poppy.Visible = false;
            txtbox_asafoetida.Visible = false;
            txtbox_mint.Visible = false;
            txtbox_ginger.Visible = false;
            txtbox_garlic.Visible = false;
            txtbox_curry.Visible = false;
            txtbox_nutmeg.Visible = false;
            txtbox_coriander.Visible = false;
            txtbox_green_chillies.Visible = false;
            txtbox_dry_coconut.Visible = false;

            // NON-VEG FOODS //

            lbl_egg_white.Visible = false;
            lbl_egg_yolk.Visible = false;
            lbl_chicken_leg.Visible = false;
            lbl_chicken_thigh.Visible = false;
            lbl_chicken_breast.Visible = false;
            lbl_chicken_liver.Visible = false;
            lbl_pork.Visible = false;
            lbl_sheep.Visible = false;
            lbl_pomfret.Visible = false;
            lbl_tuna.Visible = false;
            lbl_salmon.Visible = false;
            lbl_crab.Visible = false;
            lbl_oyster.Visible = false;

            lbl_cal_egg_white.Visible = false;
            lbl_cal_egg_yolk.Visible = false;
            lbl_cal_chicken_leg.Visible = false;
            lbl_cal_chicken_thigh.Visible = false;
            lbl_cal_chicken_breast.Visible = false;
            lbl_cal_chicken_liver.Visible = false;
            lbl_cal_pork.Visible = false;
            lbl_cal_sheep.Visible = false;
            lbl_cal_pomfret.Visible = false;
            lbl_cal_tuna.Visible = false;
            lbl_cal_salmon.Visible = false;
            lbl_cal_crab.Visible = false;
            lbl_cal_oyster.Visible = false;

            txtbox_egg_white.Visible = false;
            txtbox_egg_yolk.Visible = false;
            txtbox_chicken_leg.Visible = false;
            txtbox_chicken_thigh.Visible = false;
            txtbox_chicken_breast.Visible = false;
            txtbox_chicken_liver.Visible = false;
            txtbox_pork.Visible = false;
            txtbox_sheep.Visible = false;
            txtbox_pomfret.Visible = false;
            txtbox_tuna.Visible = false;
            txtbox_salmon.Visible = false;
            txtbox_crab.Visible = false;
            txtbox_oyster.Visible = false;

            // NUTS AND SEEDS //

            lbl_almond.Visible = true;
            lbl_cashew.Visible = true;
            lbl_ground.Visible = true;
            lbl_linseeds.Visible = true;
            lbl_pine.Visible = true;
            lbl_pistachio.Visible = true;
            lbl_sunflower.Visible = true;
            lbl_walnut.Visible = true;
            lbl_flax.Visible = true;
            lbl_chia.Visible = true;

            lbl_cal_almond.Visible = true;
            lbl_cal_cashew.Visible = true;
            lbl_cal_ground.Visible = true;
            lbl_cal_linseeds.Visible = true;
            lbl_cal_pine.Visible = true;
            lbl_cal_pistachio.Visible = true;
            lbl_cal_sunflower.Visible = true;
            lbl_cal_walnut.Visible = true;
            lbl_cal_flax.Visible = true;
            lbl_cal_chia.Visible = true;

            txtbox_almond.Visible = true;
            txtbox_cashew.Visible = true;
            txtbox_ground.Visible = true;
            txtbox_linseeds.Visible = true;
            txtbox_pine.Visible = true;
            txtbox_pistachio.Visible = true;
            txtbox_sunflower.Visible = true;
            txtbox_walnut.Visible = true;
            txtbox_flax.Visible = true;
            txtbox_chia.Visible = true;

            // MILK PRODUCTS //

            lbl_buffalo.Visible = false;
            lbl_cow.Visible = false;
            lbl_soy.Visible = false;
            lbl_tofu.Visible = false;
            lbl_paneer.Visible = false;
            lbl_cheese.Visible = false;
            lbl_khoa.Visible = false;

            lbl_cal_buffalo.Visible = false;
            lbl_cal_cow.Visible = false;
            lbl_cal_soy.Visible = false;
            lbl_cal_tofu.Visible = false;
            lbl_cal_paneer.Visible = false;
            lbl_cal_cheese.Visible = false;
            lbl_cal_khoa.Visible = false;

            txtbox_buffalo.Visible = false;
            txtbox_cow.Visible = false;
            txtbox_soy.Visible = false;
            txtbox_tofu.Visible = false;
            txtbox_paneer.Visible = false;
            txtbox_cheese.Visible = false;
            txtbox_khoa.Visible = false;
        }

        private void btn_milk_Click(object sender, EventArgs e)
        {
            //  BUTTONS //

            btn_add.Visible = false;
            btn_add1.Visible = false;
            btn_add2.Visible = false;
            btn_add3.Visible = false;
            btn_add4.Visible = false;
            btn_add5.Visible = false;
            btn_add6.Visible = false;
            btn_add7.Visible = true;

            // CEREALS //

            lbl_barley.Visible = false;
            lbl_refined_flour.Visible = false;
            lbl_rice.Visible = false;
            lbl_rice_flakes.Visible = false;
            lbl_wheat_flour.Visible = false;
            lbl_bajra.Visible = false;
            lbl_jowar.Visible = false;
            lbl_quinoa.Visible = false;
            lbl_ragi.Visible = false;
            lbl_semolina.Visible = false;
            lbl_vermicelli.Visible = false;

            lbl_cal_barley.Visible = false;
            lbl_cal_refined_flour.Visible = false;
            lbl_cal_rice.Visible = false;
            lbl_cal_rice_flakes.Visible = false;
            lbl_cal_wheat_flour.Visible = false;
            lbl_cal_bajra.Visible = false;
            lbl_cal_jowar.Visible = false;
            lbl_cal_quinoa.Visible = false;
            lbl_cal_ragi.Visible = false;
            lbl_cal_semolina.Visible = false;
            lbl_cal_vermicelli.Visible = false;

            txtbox_barley.Visible = false;
            txtbox_refined_flour.Visible = false;
            txtbox_rice.Visible = false;
            txtbox_rice_flakes.Visible = false;
            txtbox_wheat_flour.Visible = false;
            txtbox_bajra.Visible = false; ;
            txtbox_jowar.Visible = false;
            txtbox_quinoa.Visible = false;
            txtbox_ragi.Visible = false;
            txtbox_semolina.Visible = false;
            txtbox_vermicelli.Visible = false;

            //  VEGETABLES //

            lbl_bottle.Visible = false;
            lbl_bitter.Visible = false;
            lbl_brinjal.Visible = false;
            lbl_capsicum.Visible = false;
            lbl_cauliflower.Visible = false;
            lbl_cucumber.Visible = false;
            lbl_french.Visible = false;
            lbl_lady.Visible = false;
            lbl_peas.Visible = false;
            lbl_pumpkin.Visible = false;
            lbl_tomato.Visible = false;
            lbl_beetroot.Visible = false;
            lbl_carrot.Visible = false;
            lbl_potato.Visible = false;
            lbl_radish.Visible = false;
            lbl_sweet.Visible = false;
            lbl_ash.Visible = false;

            lbl_cal_bottle.Visible = false;
            lbl_cal_bitter.Visible = false;
            lbl_cal_brinjal.Visible = false;
            lbl_cal_capsicum.Visible = false;
            lbl_cal_cauliflower.Visible = false;
            lbl_cal_cucumber.Visible = false;
            lbl_cal_french.Visible = false;
            lbl_cal_lady.Visible = false;
            lbl_cal_peas.Visible = false;
            lbl_cal_pumpkin.Visible = false;
            lbl_cal_tomato.Visible = false;
            lbl_cal_beetroot.Visible = false;
            lbl_cal_carrot.Visible = false;
            lbl_cal_potato.Visible = false;
            lbl_cal_radish.Visible = false;
            lbl_cal_sweet.Visible = false;
            lbl_cal_ash.Visible = false;

            txtbox_bottle.Visible = false;
            txtbox_bitter.Visible = false;
            txtbox_brinjal.Visible = false;
            txtbox_capsicum.Visible = false;
            txtbox_cauliflower.Visible = false;
            txtbox_cucumber.Visible = false;
            txtbox_french.Visible = false;
            txtbox_lady.Visible = false;
            txtbox_peas.Visible = false;
            txtbox_pumpkin.Visible = false;
            txtbox_tomato.Visible = false;
            txtbox_beetroot.Visible = false;
            txtbox_carrot.Visible = false;
            txtbox_potato.Visible = false;
            txtbox_radish.Visible = false;
            txtbox_sweet.Visible = false;
            txtbox_ash.Visible = false;

            // GREEN-LEAFY VEGETABLES //

            lbl_spinach.Visible = false;
            lbl_radish_leaves.Visible = false;
            lbl_parsley.Visible = false;
            lbl_lettuce.Visible = false;
            lbl_cauliflower_leaves.Visible = false;
            lbl_cabbage.Visible = false;
            lbl_brussel.Visible = false;
            lbl_fenugreek.Visible = false;
            lbl_beet.Visible = false;
            lbl_drumstick.Visible = false;

            lbl_cal_spinach.Visible = false;
            lbl_cal_radish_leaves.Visible = false;
            lbl_cal_parsley.Visible = false;
            lbl_cal_lettuce.Visible = false;
            lbl_cal_cauliflower_leaves.Visible = false;
            lbl_cal_cabbage.Visible = false;
            lbl_cal_brussel.Visible = false;
            lbl_cal_fenugreek.Visible = false;
            lbl_cal_beet.Visible = false;
            lbl_cal_drumstick.Visible = false;

            txtbox_spinach.Visible = false;
            txtbox_radish_leaves.Visible = false;
            txtbox_parsley.Visible = false;
            txtbox_lettuce.Visible = false;
            txtbox_cauliflower_leaves.Visible = false;
            txtbox_cabbage.Visible = false;
            txtbox_brussel.Visible = false;
            txtbox_fenugreek.Visible = false;
            txtbox_beet.Visible = false;
            txtbox_drumstick.Visible = false;

            // FRUITS //

            lbl_apple.Visible = false;
            lbl_watermelon.Visible = false;
            lbl_strawberry.Visible = false;
            lbl_banana.Visible = false;
            lbl_cherries.Visible = false;
            lbl_grapes.Visible = false;
            lbl_pomegranate.Visible = false;
            lbl_pear.Visible = false;
            lbl_guava.Visible = false;
            lbl_blackcurrants.Visible = false;
            lbl_plum.Visible = false;
            lbl_litchi.Visible = false;
            lbl_pineapple.Visible = false;
            lbl_mango.Visible = false;
            lbl_orange.Visible = false;
            lbl_peach.Visible = false;
            lbl_musk.Visible = false;
            lbl_avocado.Visible = false;
            lbl_dry.Visible = false;

            lbl_cal_apple.Visible = false;
            lbl_cal_watermelon.Visible = false;
            lbl_cal_strawberry.Visible = false;
            lbl_cal_banana.Visible = false;
            lbl_cal_cherries.Visible = false;
            lbl_cal_grapes.Visible = false;
            lbl_cal_pomegranate.Visible = false;
            lbl_cal_pear.Visible = false;
            lbl_cal_guava.Visible = false;
            lbl_cal_blackcurrants.Visible = false;
            lbl_cal_plum.Visible = false;
            lbl_cal_litchi.Visible = false;
            lbl_cal_pineapple.Visible = false;
            lbl_cal_mango.Visible = false;
            lbl_cal_orange.Visible = false;
            lbl_cal_peach.Visible = false;
            lbl_cal_musk.Visible = false;
            lbl_cal_avocado.Visible = false;
            lbl_cal_dry.Visible = false;

            txtbox_apple.Visible = false;
            txtbox_watermelon.Visible = false;
            txtbox_strawberry.Visible = false;
            txtbox_banana.Visible = false;
            txtbox_cherries.Visible = false;
            txtbox_grapes.Visible = false;
            txtbox_pomegranate.Visible = false;
            txtbox_pear.Visible = false;
            txtbox_guava.Visible = false;
            txtbox_blackcurrants.Visible = false;
            txtbox_plum.Visible = false;
            txtbox_litchi.Visible = false;
            txtbox_pineapple.Visible = false;
            txtbox_mango.Visible = false;
            txtbox_orange.Visible = false;
            txtbox_peach.Visible = false;
            txtbox_musk.Visible = false;
            txtbox_avocado.Visible = false;
            txtbox_dry.Visible = false;

            // SPICES AND CONDIMENTS //

            lbl_turmeric.Visible = false;
            lbl_black_pepper.Visible = false;
            lbl_fenugeek_seeds.Visible = false;
            lbl_kalonji.Visible = false;
            lbl_cumin.Visible = false;
            lbl_cloves.Visible = false;
            lbl_red_chillies.Visible = false;
            lbl_green_cardamom.Visible = false;
            lbl_poppy.Visible = false;
            lbl_asafoetida.Visible = false;
            lbl_mint.Visible = false;
            lbl_ginger.Visible = false;
            lbl_garlic.Visible = false;
            lbl_curry.Visible = false;
            lbl_nutmeg.Visible = false;
            lbl_coriander.Visible = false;
            lbl_green_chillies.Visible = false;
            lbl_dry_coconut.Visible = false;

            lbl_cal_turmeric.Visible = false;
            lbl_cal_black_pepper.Visible = false;
            lbl_cal_fenugeek_seeds.Visible = false;
            lbl_cal_kalonji.Visible = false;
            lbl_cal_cumin.Visible = false;
            lbl_cal_cloves.Visible = false;
            lbl_cal_red_chillies.Visible = false;
            lbl_cal_green_cardamom.Visible = false;
            lbl_cal_poppy.Visible = false;
            lbl_cal_asafoetida.Visible = false;
            lbl_cal_mint.Visible = false;
            lbl_cal_ginger.Visible = false;
            lbl_cal_garlic.Visible = false;
            lbl_cal_curry.Visible = false;
            lbl_cal_nutmeg.Visible = false;
            lbl_cal_coriander.Visible = false;
            lbl_cal_green_chillies.Visible = false;
            lbl_cal_dry_coconut.Visible = false;

            txtbox_turmeric.Visible = false;
            txtbox_black_pepper.Visible = false;
            txtbox_fenugeek_seeds.Visible = false;
            txtbox_kalonji.Visible = false;
            txtbox_cumin.Visible = false;
            txtbox_cloves.Visible = false;
            txtbox_red_chillies.Visible = false;
            txtbox_green_cardamom.Visible = false;
            txtbox_poppy.Visible = false;
            txtbox_asafoetida.Visible = false;
            txtbox_mint.Visible = false;
            txtbox_ginger.Visible = false;
            txtbox_garlic.Visible = false;
            txtbox_curry.Visible = false;
            txtbox_nutmeg.Visible = false;
            txtbox_coriander.Visible = false;
            txtbox_green_chillies.Visible = false;
            txtbox_dry_coconut.Visible = false;

            // NON-VEG FOODS //

            lbl_egg_white.Visible = false;
            lbl_egg_yolk.Visible = false;
            lbl_chicken_leg.Visible = false;
            lbl_chicken_thigh.Visible = false;
            lbl_chicken_breast.Visible = false;
            lbl_chicken_liver.Visible = false;
            lbl_pork.Visible = false;
            lbl_sheep.Visible = false;
            lbl_pomfret.Visible = false;
            lbl_tuna.Visible = false;
            lbl_salmon.Visible = false;
            lbl_crab.Visible = false;
            lbl_oyster.Visible = false;

            lbl_cal_egg_white.Visible = false;
            lbl_cal_egg_yolk.Visible = false;
            lbl_cal_chicken_leg.Visible = false;
            lbl_cal_chicken_thigh.Visible = false;
            lbl_cal_chicken_breast.Visible = false;
            lbl_cal_chicken_liver.Visible = false;
            lbl_cal_pork.Visible = false;
            lbl_cal_sheep.Visible = false;
            lbl_cal_pomfret.Visible = false;
            lbl_cal_tuna.Visible = false;
            lbl_cal_salmon.Visible = false;
            lbl_cal_crab.Visible = false;
            lbl_cal_oyster.Visible = false;

            txtbox_egg_white.Visible = false;
            txtbox_egg_yolk.Visible = false;
            txtbox_chicken_leg.Visible = false;
            txtbox_chicken_thigh.Visible = false;
            txtbox_chicken_breast.Visible = false;
            txtbox_chicken_liver.Visible = false;
            txtbox_pork.Visible = false;
            txtbox_sheep.Visible = false;
            txtbox_pomfret.Visible = false;
            txtbox_tuna.Visible = false;
            txtbox_salmon.Visible = false;
            txtbox_crab.Visible = false;
            txtbox_oyster.Visible = false;

            // NUTS AND SEEDS //

            lbl_almond.Visible = false;
            lbl_cashew.Visible = false;
            lbl_ground.Visible = false;
            lbl_linseeds.Visible = false;
            lbl_pine.Visible = false;
            lbl_pistachio.Visible = false;
            lbl_sunflower.Visible = false;
            lbl_walnut.Visible = false;
            lbl_flax.Visible = false;
            lbl_chia.Visible = false;

            lbl_cal_almond.Visible = false;
            lbl_cal_cashew.Visible = false;
            lbl_cal_ground.Visible = false;
            lbl_cal_linseeds.Visible = false;
            lbl_cal_pine.Visible = false;
            lbl_cal_pistachio.Visible = false;
            lbl_cal_sunflower.Visible = false;
            lbl_cal_walnut.Visible = false;
            lbl_cal_flax.Visible = false;
            lbl_cal_chia.Visible = false;

            txtbox_almond.Visible = false;
            txtbox_cashew.Visible = false;
            txtbox_ground.Visible = false;
            txtbox_linseeds.Visible = false;
            txtbox_pine.Visible = false;
            txtbox_pistachio.Visible = false;
            txtbox_sunflower.Visible = false;
            txtbox_walnut.Visible = false;
            txtbox_flax.Visible = false;
            txtbox_chia.Visible = false;

            // MILK PRODUCTS //

            lbl_buffalo.Visible = true;
            lbl_cow.Visible = true;
            lbl_soy.Visible = true;
            lbl_tofu.Visible = true;
            lbl_paneer.Visible = true;
            lbl_cheese.Visible = true;
            lbl_khoa.Visible = true;

            lbl_cal_buffalo.Visible = true;
            lbl_cal_cow.Visible = true;
            lbl_cal_soy.Visible = true;
            lbl_cal_tofu.Visible = true;
            lbl_cal_paneer.Visible = true;
            lbl_cal_cheese.Visible = true;
            lbl_cal_khoa.Visible = true;

            txtbox_buffalo.Visible = true;
            txtbox_cow.Visible = true;
            txtbox_soy.Visible = true;
            txtbox_tofu.Visible = true;
            txtbox_paneer.Visible = true;
            txtbox_cheese.Visible = true;
            txtbox_khoa.Visible = true;
        }

        private void combo_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_menu.Text == "Cereals")
                btn_cereals_Click(sender, e);
            if (combo_menu.Text == "Vegetables")
                btn_vegetables_Click(sender, e);
            if (combo_menu.Text == "Green-leafy vegetables")
                btn_green_leafy_Click(sender, e);
            if (combo_menu.Text == "Fruits")
                btn_fruits_Click(sender, e);
            if (combo_menu.Text == "Spices and condiments")
                btn_spices_Click(sender, e);
            if (combo_menu.Text == "Non-veg foods")
                btn_nonveg_Click(sender, e);
            if (combo_menu.Text == "Nuts and seeds")
                btn_nuts_Click(sender, e);
            if (combo_menu.Text == "Milk products")
                btn_milk_Click(sender, e);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (txtbox_barley.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_barley.Text) * (double.Parse(txtbox_barley.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_barley.Text) * (double.Parse(txtbox_barley.Text) / 100);
                listbox_total.Items.Add(lbl_barley.Text + "  " + grams + "Kcal");
            }
            if (txtbox_refined_flour.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_refined_flour.Text) * (double.Parse(txtbox_refined_flour.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_refined_flour.Text) * (double.Parse(txtbox_refined_flour.Text) / 100);
                listbox_total.Items.Add(lbl_refined_flour.Text + "  " + grams + "Kcal");
            }
            if (txtbox_rice.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_rice.Text) * (double.Parse(txtbox_rice.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_rice.Text) * (double.Parse(txtbox_rice.Text) / 100);
                listbox_total.Items.Add(lbl_rice.Text + "  " + grams + "Kcal");
            }
            if (txtbox_rice_flakes.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_rice_flakes.Text) * (double.Parse(txtbox_rice_flakes.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_rice_flakes.Text) * (double.Parse(txtbox_rice_flakes.Text) / 100);
                listbox_total.Items.Add(lbl_rice_flakes.Text + "  " + grams + "Kcal");
            }
            if (txtbox_wheat_flour.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_wheat_flour.Text) * (double.Parse(txtbox_wheat_flour.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_wheat_flour.Text) * (double.Parse(txtbox_wheat_flour.Text) / 100);
                listbox_total.Items.Add(lbl_wheat_flour.Text + "  " + grams + "Kcal");
            }
            if (txtbox_bajra.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_bajra.Text) * (double.Parse(txtbox_bajra.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_bajra.Text) * (double.Parse(txtbox_bajra.Text) / 100);
                listbox_total.Items.Add(lbl_bajra.Text + "  " + grams + "Kcal");
            }
            if (txtbox_jowar.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_jowar.Text) * (double.Parse(txtbox_jowar.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_jowar.Text) * (double.Parse(txtbox_jowar.Text) / 100);
                listbox_total.Items.Add(lbl_jowar.Text + "  " + grams + "Kcal");
            }
            if (txtbox_quinoa.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_quinoa.Text) * (double.Parse(txtbox_quinoa.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_quinoa.Text) * (double.Parse(txtbox_quinoa.Text) / 100);
                listbox_total.Items.Add(lbl_quinoa.Text + "  " + grams + "Kcal");
            }
            if (txtbox_ragi.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_ragi.Text) * (double.Parse(txtbox_ragi.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_ragi.Text) * (double.Parse(txtbox_ragi.Text) / 100);
                listbox_total.Items.Add(lbl_ragi.Text + "  " + grams + "Kcal");
            }
            if (txtbox_semolina.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_semolina.Text) * (double.Parse(txtbox_semolina.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_semolina.Text) * (double.Parse(txtbox_semolina.Text) / 100);
                listbox_total.Items.Add(lbl_semolina.Text + "  " + grams + "Kcal");
            }
            if (txtbox_vermicelli.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_vermicelli.Text) * (double.Parse(txtbox_vermicelli.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_vermicelli.Text) * (double.Parse(txtbox_vermicelli.Text) / 100);
                listbox_total.Items.Add(lbl_vermicelli.Text + "  " + grams + "Kcal");
            }


            txtbox_barley.Text = "";
            txtbox_refined_flour.Text = "";
            txtbox_rice.Text = "";
            txtbox_rice_flakes.Text = "";
            txtbox_wheat_flour.Text = "";
            txtbox_bajra.Text = "";
            txtbox_jowar.Text = "";
            txtbox_quinoa.Text = "";
            txtbox_ragi.Text = "";
            txtbox_semolina.Text = "";
            txtbox_vermicelli.Text = "";

            lbl_calories.Text = calories.ToString();
        }

        private void btn_add1_Click(object sender, EventArgs e)
        {
            if (txtbox_bottle.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_bottle.Text) * (double.Parse(txtbox_bottle.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_bottle.Text) * (double.Parse(txtbox_bottle.Text) / 100);
                listbox_total.Items.Add(lbl_bottle.Text + "  " + grams + "Kcal");
            }
            if (txtbox_bitter.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_bitter.Text) * (double.Parse(txtbox_bitter.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_bitter.Text) * (double.Parse(txtbox_bitter.Text) / 100);
                listbox_total.Items.Add(lbl_bitter.Text + "  " + grams + "Kcal");
            }
            if (txtbox_brinjal.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_brinjal.Text) * (double.Parse(txtbox_brinjal.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_brinjal.Text) * (double.Parse(txtbox_brinjal.Text) / 100);
                listbox_total.Items.Add(lbl_brinjal.Text + "  " + grams + "Kcal");
            }
            if (txtbox_capsicum.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_capsicum.Text) * (double.Parse(txtbox_capsicum.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_capsicum.Text) * (double.Parse(txtbox_capsicum.Text) / 100);
                listbox_total.Items.Add(lbl_capsicum.Text + "  " + grams + "Kcal");
            }
            if (txtbox_cauliflower.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_cauliflower.Text) * (double.Parse(txtbox_cauliflower.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_cauliflower.Text) * (double.Parse(txtbox_cauliflower.Text) / 100);
                listbox_total.Items.Add(lbl_cauliflower.Text + "  " + grams + "Kcal");
            }
            if (txtbox_cucumber.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_cucumber.Text) * (double.Parse(txtbox_cucumber.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_cucumber.Text) * (double.Parse(txtbox_cucumber.Text) / 100);
                listbox_total.Items.Add(lbl_cucumber.Text + "  " + grams + "Kcal");
            }
            if (txtbox_french.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_french.Text) * (double.Parse(txtbox_french.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_french.Text) * (double.Parse(txtbox_french.Text) / 100);
                listbox_total.Items.Add(lbl_french.Text + "  " + grams + "Kcal");
            }
            if (txtbox_lady.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_lady.Text) * (double.Parse(txtbox_lady.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_lady.Text) * (double.Parse(txtbox_lady.Text) / 100);
                listbox_total.Items.Add(lbl_lady.Text + "  " + grams + "Kcal");
            }
            if (txtbox_peas.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_peas.Text) * (double.Parse(txtbox_peas.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_peas.Text) * (double.Parse(txtbox_peas.Text) / 100);
                listbox_total.Items.Add(lbl_peas.Text + "  " + grams + "Kcal");
            }
            if (txtbox_pumpkin.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_pumpkin.Text) * (double.Parse(txtbox_pumpkin.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_pumpkin.Text) * (double.Parse(txtbox_pumpkin.Text) / 100);
                listbox_total.Items.Add(lbl_pumpkin.Text + "  " + grams + "Kcal");
            }
            if (txtbox_tomato.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_tomato.Text) * (double.Parse(txtbox_tomato.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_tomato.Text) * (double.Parse(txtbox_tomato.Text) / 100);
                listbox_total.Items.Add(lbl_tomato.Text + "  " + grams + "Kcal");
            }
            if (txtbox_beetroot.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_beetroot.Text) * (double.Parse(txtbox_beetroot.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_beetroot.Text) * (double.Parse(txtbox_beetroot.Text) / 100);
                listbox_total.Items.Add(lbl_beetroot.Text + "  " + grams + "Kcal");
            }
            if (txtbox_carrot.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_carrot.Text) * (double.Parse(txtbox_carrot.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_carrot.Text) * (double.Parse(txtbox_carrot.Text) / 100);
                listbox_total.Items.Add(lbl_carrot.Text + "  " + grams + "Kcal");
            }
            if (txtbox_potato.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_potato.Text) * (double.Parse(txtbox_potato.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_potato.Text) * (double.Parse(txtbox_potato.Text) / 100);
                listbox_total.Items.Add(lbl_potato.Text + "  " + grams + "Kcal");
            }
            if (txtbox_radish.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_radish.Text) * (double.Parse(txtbox_radish.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_radish.Text) * (double.Parse(txtbox_radish.Text) / 100);
                listbox_total.Items.Add(lbl_radish.Text + "  " + grams + "Kcal");
            }
            if (txtbox_sweet.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_sweet.Text) * (double.Parse(txtbox_sweet.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_sweet.Text) * (double.Parse(txtbox_sweet.Text) / 100);
                listbox_total.Items.Add(lbl_sweet.Text + "  " + grams + "Kcal");
            }
            if (txtbox_ash.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_ash.Text) * (double.Parse(txtbox_ash.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_ash.Text) * (double.Parse(txtbox_ash.Text) / 100);
                listbox_total.Items.Add(lbl_ash.Text + "  " + grams + "Kcal");
            }

            txtbox_bottle.Text = "";
            txtbox_bitter.Text = "";
            txtbox_brinjal.Text = "";
            txtbox_capsicum.Text = "";
            txtbox_cauliflower.Text = "";
            txtbox_cucumber.Text = "";
            txtbox_french.Text = "";
            txtbox_lady.Text = "";
            txtbox_peas.Text = "";
            txtbox_pumpkin.Text = "";
            txtbox_tomato.Text = "";
            txtbox_beetroot.Text = "";
            txtbox_carrot.Text = "";
            txtbox_potato.Text = "";
            txtbox_radish.Text = "";
            txtbox_sweet.Text = "";
            txtbox_ash.Text = "";

            lbl_calories.Text = calories.ToString();
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            if (txtbox_spinach.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_spinach.Text) * (double.Parse(txtbox_spinach.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_spinach.Text) * (double.Parse(txtbox_spinach.Text) / 100);
                listbox_total.Items.Add(lbl_spinach.Text + "  " + grams + "Kcal");
            }
            if (txtbox_radish_leaves.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_radish_leaves.Text) * (double.Parse(txtbox_radish_leaves.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_radish_leaves.Text) * (double.Parse(txtbox_radish_leaves.Text) / 100);
                listbox_total.Items.Add(lbl_radish_leaves.Text + "  " + grams + "Kcal");
            }
            if (txtbox_parsley.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_parsley.Text) * (double.Parse(txtbox_parsley.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_parsley.Text) * (double.Parse(txtbox_parsley.Text) / 100);
                listbox_total.Items.Add(lbl_parsley.Text + "  " + grams + "Kcal");
            }
            if (txtbox_lettuce.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_lettuce.Text) * (double.Parse(txtbox_lettuce.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_lettuce.Text) * (double.Parse(txtbox_lettuce.Text) / 100);
                listbox_total.Items.Add(lbl_lettuce.Text + "  " + grams + "Kcal");
            }
            if (txtbox_cauliflower_leaves.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_cauliflower_leaves.Text) * (double.Parse(txtbox_cauliflower_leaves.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_cauliflower_leaves.Text) * (double.Parse(txtbox_cauliflower_leaves.Text) / 100);
                listbox_total.Items.Add(lbl_cauliflower_leaves.Text + "  " + grams + "Kcal");
            }
            if (txtbox_cabbage.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_cabbage.Text) * (double.Parse(txtbox_cabbage.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_cabbage.Text) * (double.Parse(txtbox_cabbage.Text) / 100);
                listbox_total.Items.Add(lbl_cabbage.Text + "  " + grams + "Kcal");
            }
            if (txtbox_brussel.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_brussel.Text) * (double.Parse(txtbox_brussel.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_brussel.Text) * (double.Parse(txtbox_brussel.Text) / 100);
                listbox_total.Items.Add(lbl_brussel.Text + "  " + grams + "Kcal");
            }
            if (txtbox_fenugreek.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_fenugreek.Text) * (double.Parse(txtbox_fenugreek.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_fenugreek.Text) * (double.Parse(txtbox_fenugreek.Text) / 100);
                listbox_total.Items.Add(lbl_fenugreek.Text + "  " + grams + "Kcal");
            }
            if (txtbox_beet.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_beet.Text) * (double.Parse(txtbox_beet.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_beet.Text) * (double.Parse(txtbox_beet.Text) / 100);
                listbox_total.Items.Add(lbl_beet.Text + "  " + grams + "Kcal");
            }
            if (txtbox_drumstick.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_drumstick.Text) * (double.Parse(txtbox_drumstick.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_drumstick.Text) * (double.Parse(txtbox_drumstick.Text) / 100);
                listbox_total.Items.Add(lbl_drumstick.Text + "  " + grams + "Kcal");
            }

            txtbox_spinach.Text = "";
            txtbox_radish_leaves.Text = "";
            txtbox_parsley.Text = "";
            txtbox_lettuce.Text = "";
            txtbox_cauliflower_leaves.Text = "";
            txtbox_cabbage.Text = "";
            txtbox_brussel.Text = "";
            txtbox_fenugreek.Text = "";
            txtbox_beet.Text = "";
            txtbox_drumstick.Text = "";

            lbl_calories.Text = calories.ToString();
        }

        private void btn_add3_Click(object sender, EventArgs e)
        {
            if (txtbox_apple.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_apple.Text) * (double.Parse(txtbox_apple.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_apple.Text) * (double.Parse(txtbox_apple.Text) / 100);
                listbox_total.Items.Add(lbl_apple.Text + "  " + grams + "Kcal");
            }
            if (txtbox_watermelon.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_watermelon.Text) * (double.Parse(txtbox_watermelon.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_watermelon.Text) * (double.Parse(txtbox_watermelon.Text) / 100);
                listbox_total.Items.Add(lbl_watermelon.Text + "  " + grams + "Kcal");
            }
            if (txtbox_strawberry.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_strawberry.Text) * (double.Parse(txtbox_strawberry.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_strawberry.Text) * (double.Parse(txtbox_strawberry.Text) / 100);
                listbox_total.Items.Add(lbl_strawberry.Text + "  " + grams + "Kcal");
            }
            if (txtbox_banana.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_banana.Text) * (double.Parse(txtbox_banana.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_banana.Text) * (double.Parse(txtbox_banana.Text) / 100);
                listbox_total.Items.Add(lbl_banana.Text + "  " + grams + "Kcal");
            }
            if (txtbox_cherries.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_cherries.Text) * (double.Parse(txtbox_cherries.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_cherries.Text) * (double.Parse(txtbox_cherries.Text) / 100);
                listbox_total.Items.Add(lbl_cherries.Text + "  " + grams + "Kcal");
            }
            if (txtbox_grapes.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_grapes.Text) * (double.Parse(txtbox_grapes.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_grapes.Text) * (double.Parse(txtbox_grapes.Text) / 100);
                listbox_total.Items.Add(lbl_grapes.Text + "  " + grams + "Kcal");
            }
            if (txtbox_pomegranate.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_pomegranate.Text) * (double.Parse(txtbox_pomegranate.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_pomegranate.Text) * (double.Parse(txtbox_pomegranate.Text) / 100);
                listbox_total.Items.Add(lbl_pomegranate.Text + "  " + grams + "Kcal");
            }
            if (txtbox_pear.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_pear.Text) * (double.Parse(txtbox_pear.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_pear.Text) * (double.Parse(txtbox_pear.Text) / 100);
                listbox_total.Items.Add(lbl_pear.Text + "  " + grams + "Kcal");
            }
            if (txtbox_guava.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_guava.Text) * (double.Parse(txtbox_guava.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_guava.Text) * (double.Parse(txtbox_guava.Text) / 100);
                listbox_total.Items.Add(lbl_guava.Text + "  " + grams + "Kcal");
            }
            if (txtbox_blackcurrants.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_blackcurrants.Text) * (double.Parse(txtbox_blackcurrants.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_blackcurrants.Text) * (double.Parse(txtbox_blackcurrants.Text) / 100);
                listbox_total.Items.Add(lbl_blackcurrants.Text + "  " + grams + "Kcal");
            }
            if (txtbox_plum.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_plum.Text) * (double.Parse(txtbox_plum.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_plum.Text) * (double.Parse(txtbox_plum.Text) / 100);
                listbox_total.Items.Add(lbl_plum.Text + "  " + grams + "Kcal");
            }
            if (txtbox_litchi.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_litchi.Text) * (double.Parse(txtbox_litchi.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_litchi.Text) * (double.Parse(txtbox_litchi.Text) / 100);
                listbox_total.Items.Add(lbl_litchi.Text + "  " + grams + "Kcal");
            }
            if (txtbox_pineapple.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_pineapple.Text) * (double.Parse(txtbox_pineapple.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_pineapple.Text) * (double.Parse(txtbox_pineapple.Text) / 100);
                listbox_total.Items.Add(lbl_pineapple.Text + "  " + grams + "Kcal");
            }
            if (txtbox_mango.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_mango.Text) * (double.Parse(txtbox_mango.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_mango.Text) * (double.Parse(txtbox_mango.Text) / 100);
                listbox_total.Items.Add(lbl_mango.Text + "  " + grams + "Kcal");
            }
            if (txtbox_orange.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_orange.Text) * (double.Parse(txtbox_orange.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_orange.Text) * (double.Parse(txtbox_orange.Text) / 100);
                listbox_total.Items.Add(lbl_orange.Text + "  " + grams + "Kcal");
            }
            if (txtbox_peach.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_peach.Text) * (double.Parse(txtbox_peach.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_peach.Text) * (double.Parse(txtbox_peach.Text) / 100);
                listbox_total.Items.Add(lbl_peach.Text + "  " + grams + "Kcal");
            }
            if (txtbox_musk.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_musk.Text) * (double.Parse(txtbox_musk.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_musk.Text) * (double.Parse(txtbox_musk.Text) / 100);
                listbox_total.Items.Add(lbl_musk.Text + "  " + grams + "Kcal");
            }
            if (txtbox_avocado.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_avocado.Text) * (double.Parse(txtbox_avocado.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_avocado.Text) * (double.Parse(txtbox_avocado.Text) / 100);
                listbox_total.Items.Add(lbl_avocado.Text + "  " + grams + "Kcal");
            }
            if (txtbox_dry.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_dry.Text) * (double.Parse(txtbox_dry.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_dry.Text) * (double.Parse(txtbox_dry.Text) / 100);
                listbox_total.Items.Add(lbl_dry.Text + "  " + grams + "Kcal");
            }

            txtbox_apple.Text = "";
            txtbox_watermelon.Text = "";
            txtbox_strawberry.Text = "";
            txtbox_banana.Text = "";
            txtbox_cherries.Text = "";
            txtbox_grapes.Text = "";
            txtbox_pomegranate.Text = "";
            txtbox_pear.Text = "";
            txtbox_guava.Text = "";
            txtbox_blackcurrants.Text = "";
            txtbox_plum.Text = "";
            txtbox_litchi.Text = "";
            txtbox_pineapple.Text = "";
            txtbox_mango.Text = "";
            txtbox_orange.Text = "";
            txtbox_peach.Text = "";
            txtbox_musk.Text = "";
            txtbox_avocado.Text = "";
            txtbox_dry.Text = "";

            lbl_calories.Text = calories.ToString();
        }

        private void btn_add4_Click(object sender, EventArgs e)
        {
            if (txtbox_turmeric.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_turmeric.Text) * (double.Parse(txtbox_turmeric.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_turmeric.Text) * (double.Parse(txtbox_turmeric.Text) / 100);
                listbox_total.Items.Add(lbl_turmeric.Text + "  " + grams + "Kcal");
            }
            if (txtbox_black_pepper.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_black_pepper.Text) * (double.Parse(txtbox_black_pepper.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_black_pepper.Text) * (double.Parse(txtbox_black_pepper.Text) / 100);
                listbox_total.Items.Add(lbl_black_pepper.Text + "  " + grams + "Kcal");
            }
            if (txtbox_fenugeek_seeds.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_fenugeek_seeds.Text) * (double.Parse(txtbox_fenugeek_seeds.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_fenugeek_seeds.Text) * (double.Parse(txtbox_fenugeek_seeds.Text) / 100);
                listbox_total.Items.Add(lbl_fenugeek_seeds.Text + "  " + grams + "Kcal");
            }
            if (txtbox_kalonji.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_kalonji.Text) * (double.Parse(txtbox_kalonji.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_kalonji.Text) * (double.Parse(txtbox_kalonji.Text) / 100);
                listbox_total.Items.Add(lbl_kalonji.Text + "  " + grams + "Kcal");
            }
            if (txtbox_cumin.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_cumin.Text) * (double.Parse(txtbox_cumin.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_cumin.Text) * (double.Parse(txtbox_cumin.Text) / 100);
                listbox_total.Items.Add(lbl_cumin.Text + "  " + grams + "Kcal");
            }
            if (txtbox_cloves.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_cloves.Text) * (double.Parse(txtbox_cloves.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_cloves.Text) * (double.Parse(txtbox_cloves.Text) / 100);
                listbox_total.Items.Add(lbl_cloves.Text + "  " + grams + "Kcal");
            }
            if (txtbox_red_chillies.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_red_chillies.Text) * (double.Parse(txtbox_red_chillies.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_red_chillies.Text) * (double.Parse(txtbox_red_chillies.Text) / 100);
                listbox_total.Items.Add(lbl_red_chillies.Text + "  " + grams + "Kcal");
            }
            if (txtbox_green_cardamom.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_green_cardamom.Text) * (double.Parse(txtbox_green_cardamom.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_green_cardamom.Text) * (double.Parse(txtbox_green_cardamom.Text) / 100);
                listbox_total.Items.Add(lbl_green_cardamom.Text + "  " + grams + "Kcal");
            }
            if (txtbox_poppy.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_poppy.Text) * (double.Parse(txtbox_poppy.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_poppy.Text) * (double.Parse(txtbox_poppy.Text) / 100);
                listbox_total.Items.Add(lbl_poppy.Text + "  " + grams + "Kcal");
            }
            if (txtbox_asafoetida.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_asafoetida.Text) * (double.Parse(txtbox_asafoetida.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_asafoetida.Text) * (double.Parse(txtbox_asafoetida.Text) / 100);
                listbox_total.Items.Add(lbl_asafoetida.Text + "  " + grams + "Kcal");
            }
            if (txtbox_mint.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_mint.Text) * (double.Parse(txtbox_mint.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_mint.Text) * (double.Parse(txtbox_mint.Text) / 100);
                listbox_total.Items.Add(lbl_mint.Text + "  " + grams + "Kcal");
            }
            if (txtbox_ginger.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_ginger.Text) * (double.Parse(txtbox_ginger.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_ginger.Text) * (double.Parse(txtbox_ginger.Text) / 100);
                listbox_total.Items.Add(lbl_ginger.Text + "  " + grams + "Kcal");
            }
            if (txtbox_garlic.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_garlic.Text) * (double.Parse(txtbox_garlic.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_garlic.Text) * (double.Parse(txtbox_garlic.Text) / 100);
                listbox_total.Items.Add(lbl_garlic.Text + "  " + grams + "Kcal");
            }
            if (txtbox_curry.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_curry.Text) * (double.Parse(txtbox_curry.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_curry.Text) * (double.Parse(txtbox_curry.Text) / 100);
                listbox_total.Items.Add(lbl_curry.Text + "  " + grams + "Kcal");
            }
            if (txtbox_nutmeg.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_nutmeg.Text) * (double.Parse(txtbox_nutmeg.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_nutmeg.Text) * (double.Parse(txtbox_nutmeg.Text) / 100);
                listbox_total.Items.Add(lbl_nutmeg.Text + "  " + grams + "Kcal");
            }
            if (txtbox_coriander.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_coriander.Text) * (double.Parse(txtbox_coriander.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_coriander.Text) * (double.Parse(txtbox_coriander.Text) / 100);
                listbox_total.Items.Add(lbl_coriander.Text + "  " + grams + "Kcal");
            }
            if (txtbox_green_chillies.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_green_chillies.Text) * (double.Parse(txtbox_green_chillies.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_green_chillies.Text) * (double.Parse(txtbox_green_chillies.Text) / 100);
                listbox_total.Items.Add(lbl_green_chillies.Text + "  " + grams + "Kcal");
            }
            if (txtbox_dry_coconut.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_dry_coconut.Text) * (double.Parse(txtbox_dry_coconut.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_dry_coconut.Text) * (double.Parse(txtbox_dry_coconut.Text) / 100);
                listbox_total.Items.Add(lbl_dry_coconut.Text + "  " + grams + "Kcal");
            }

            txtbox_turmeric.Text = "";
            txtbox_black_pepper.Text = "";
            txtbox_fenugeek_seeds.Text = "";
            txtbox_kalonji.Text = "";
            txtbox_cumin.Text = "";
            txtbox_cloves.Text = "";
            txtbox_red_chillies.Text = "";
            txtbox_green_cardamom.Text = "";
            txtbox_poppy.Text = "";
            txtbox_asafoetida.Text = "";
            txtbox_mint.Text = "";
            txtbox_ginger.Text = "";
            txtbox_garlic.Text = "";
            txtbox_curry.Text = "";
            txtbox_nutmeg.Text = "";
            txtbox_coriander.Text = "";
            txtbox_green_chillies.Text = "";
            txtbox_dry_coconut.Text = "";

            lbl_calories.Text = calories.ToString();
        }

        private void btn_add5_Click(object sender, EventArgs e)
        {
            if (txtbox_egg_white.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_egg_white.Text) * (double.Parse(txtbox_egg_white.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_egg_white.Text) * (double.Parse(txtbox_egg_white.Text) / 100);
                listbox_total.Items.Add(lbl_egg_white.Text + "  " + grams + "Kcal");
            }
            if (txtbox_egg_yolk.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_egg_yolk.Text) * (double.Parse(txtbox_egg_yolk.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_egg_yolk.Text) * (double.Parse(txtbox_egg_yolk.Text) / 100);
                listbox_total.Items.Add(lbl_egg_yolk.Text + "  " + grams + "Kcal");
            }
            if (txtbox_chicken_leg.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_chicken_leg.Text) * (double.Parse(txtbox_chicken_leg.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_chicken_leg.Text) * (double.Parse(txtbox_chicken_leg.Text) / 100);
                listbox_total.Items.Add(lbl_chicken_leg.Text + "  " + grams + "Kcal");
            }
            if (txtbox_chicken_thigh.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_chicken_thigh.Text) * (double.Parse(txtbox_chicken_thigh.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_chicken_thigh.Text) * (double.Parse(txtbox_chicken_thigh.Text) / 100);
                listbox_total.Items.Add(lbl_chicken_thigh.Text + "  " + grams + "Kcal");
            }
            if (txtbox_chicken_breast.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_chicken_breast.Text) * (double.Parse(txtbox_chicken_breast.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_chicken_breast.Text) * (double.Parse(txtbox_chicken_breast.Text) / 100);
                listbox_total.Items.Add(lbl_chicken_breast.Text + "  " + grams + "Kcal");
            }
            if (txtbox_chicken_liver.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_chicken_liver.Text) * (double.Parse(txtbox_chicken_liver.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_chicken_liver.Text) * (double.Parse(txtbox_chicken_liver.Text) / 100);
                listbox_total.Items.Add(lbl_chicken_liver.Text + "  " + grams + "Kcal");
            }
            if (txtbox_pork.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_pork.Text) * (double.Parse(txtbox_pork.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_pork.Text) * (double.Parse(txtbox_pork.Text) / 100);
                listbox_total.Items.Add(lbl_pork.Text + "  " + grams + "Kcal");
            }
            if (txtbox_sheep.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_sheep.Text) * (double.Parse(txtbox_sheep.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_sheep.Text) * (double.Parse(txtbox_sheep.Text) / 100);
                listbox_total.Items.Add(lbl_sheep.Text + "  " + grams + "Kcal");
            }
            if (txtbox_pomfret.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_pomfret.Text) * (double.Parse(txtbox_pomfret.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_pomfret.Text) * (double.Parse(txtbox_pomfret.Text) / 100);
                listbox_total.Items.Add(lbl_pomfret.Text + "  " + grams + "Kcal");
            }
            if (txtbox_tuna.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_tuna.Text) * (double.Parse(txtbox_tuna.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_tuna.Text) * (double.Parse(txtbox_tuna.Text) / 100);
                listbox_total.Items.Add(lbl_tuna.Text + "  " + grams + "Kcal");
            }
            if (txtbox_salmon.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_salmon.Text) * (double.Parse(txtbox_salmon.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_salmon.Text) * (double.Parse(txtbox_salmon.Text) / 100);
                listbox_total.Items.Add(lbl_salmon.Text + "  " + grams + "Kcal");
            }
            if (txtbox_crab.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_crab.Text) * (double.Parse(txtbox_crab.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_crab.Text) * (double.Parse(txtbox_crab.Text) / 100);
                listbox_total.Items.Add(lbl_crab.Text + "  " + grams + "Kcal");
            }
            if (txtbox_oyster.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_oyster.Text) * (double.Parse(txtbox_oyster.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_oyster.Text) * (double.Parse(txtbox_oyster.Text) / 100);
                listbox_total.Items.Add(lbl_oyster.Text + "  " + grams + "Kcal");
            }

            txtbox_egg_white.Text = "";
            txtbox_egg_yolk.Text = "";
            txtbox_chicken_leg.Text = "";
            txtbox_chicken_thigh.Text = "";
            txtbox_chicken_breast.Text = "";
            txtbox_chicken_liver.Text = "";
            txtbox_pork.Text = "";
            txtbox_sheep.Text = "";
            txtbox_pomfret.Text = "";
            txtbox_tuna.Text = "";
            txtbox_salmon.Text = "";
            txtbox_crab.Text = "";
            txtbox_oyster.Text = "";

            lbl_calories.Text = calories.ToString();
        }

        private void btn_add6_Click(object sender, EventArgs e)
        {
            if (txtbox_almond.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_almond.Text) * (double.Parse(txtbox_almond.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_almond.Text) * (double.Parse(txtbox_almond.Text) / 100);
                listbox_total.Items.Add(lbl_almond.Text + "  " + grams + "Kcal");
            }
            if (txtbox_cashew.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_cashew.Text) * (double.Parse(txtbox_cashew.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_cashew.Text) * (double.Parse(txtbox_cashew.Text) / 100);
                listbox_total.Items.Add(lbl_cashew.Text + "  " + grams + "Kcal");
            }
                
            if (txtbox_ground.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_ground.Text) * (double.Parse(txtbox_ground.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_ground.Text) * (double.Parse(txtbox_ground.Text) / 100);
                listbox_total.Items.Add(lbl_ground.Text + "  " + grams + "Kcal");
            }

            if (txtbox_linseeds.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_linseeds.Text) * (double.Parse(txtbox_linseeds.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_linseeds.Text) * (double.Parse(txtbox_linseeds.Text) / 100);
                listbox_total.Items.Add(lbl_linseeds.Text + "  " + grams + "Kcal");
            }
            if (txtbox_pine.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_pine.Text) * (double.Parse(txtbox_pine.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_pine.Text) * (double.Parse(txtbox_pine.Text) / 100);
                listbox_total.Items.Add(lbl_pine.Text + "  " + grams + "Kcal");
            }
            if (txtbox_pistachio.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_pistachio.Text) * (double.Parse(txtbox_pistachio.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_pistachio.Text) * (double.Parse(txtbox_pistachio.Text) / 100);
                listbox_total.Items.Add(lbl_pistachio.Text + "  " + grams + "Kcal");
            }
            if (txtbox_sunflower.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_sunflower.Text) * (double.Parse(txtbox_sunflower.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_sunflower.Text) * (double.Parse(txtbox_sunflower.Text) / 100);
                listbox_total.Items.Add(lbl_sunflower.Text + "  " + grams + "Kcal");
            }
            if (txtbox_walnut.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_walnut.Text) * (double.Parse(txtbox_walnut.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_walnut.Text) * (double.Parse(txtbox_walnut.Text) / 100);
                listbox_total.Items.Add(lbl_walnut.Text + "  " + grams + "Kcal");
            }
            if (txtbox_flax.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_flax.Text) * (double.Parse(txtbox_flax.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_flax.Text) * (double.Parse(txtbox_flax.Text) / 100);
                listbox_total.Items.Add(lbl_flax.Text + "  " + grams + "Kcal");
            }
            if (txtbox_chia.Text != "") 
            {
                calories += Convert.ToDouble(lbl_cal_chia.Text) * (double.Parse(txtbox_chia.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_chia.Text) * (double.Parse(txtbox_chia.Text) / 100);
                listbox_total.Items.Add(lbl_chia.Text + "  " + grams + "Kcal");
            }

            txtbox_almond.Text = "";
            txtbox_cashew.Text = "";
            txtbox_ground.Text = "";
            txtbox_linseeds.Text = "";
            txtbox_pine.Text = "";
            txtbox_pistachio.Text = "";
            txtbox_sunflower.Text = "";
            txtbox_walnut.Text = "";
            txtbox_flax.Text = "";
            txtbox_chia.Text = "";

            lbl_calories.Text = calories.ToString();
        }

        private void btn_add7_Click(object sender, EventArgs e)
        {
            if (txtbox_buffalo.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_buffalo.Text) * (double.Parse(txtbox_buffalo.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_buffalo.Text) * (double.Parse(txtbox_buffalo.Text) / 100);
                listbox_total.Items.Add(lbl_buffalo.Text + "  " + grams + "Kcal");
            }
            if (txtbox_cow.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_cow.Text) * (double.Parse(txtbox_cow.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_cow.Text) * (double.Parse(txtbox_cow.Text) / 100);
                listbox_total.Items.Add(lbl_cow.Text + "  " + grams + "Kcal");
            }
            if (txtbox_soy.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_soy.Text) * (double.Parse(txtbox_soy.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_soy.Text) * (double.Parse(txtbox_soy.Text) / 100);
                listbox_total.Items.Add(lbl_soy.Text + "  " + grams + "Kcal");
            }
            if (txtbox_tofu.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_tofu.Text) * (double.Parse(txtbox_tofu.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_tofu.Text) * (double.Parse(txtbox_tofu.Text) / 100);
                listbox_total.Items.Add(lbl_tofu.Text + "  " + grams + "Kcal");
            }
            if (txtbox_paneer.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_paneer.Text) * (double.Parse(txtbox_paneer.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_paneer.Text) * (double.Parse(txtbox_paneer.Text) / 100);
                listbox_total.Items.Add(lbl_paneer.Text + "  " + grams + "Kcal");
            }
            if (txtbox_cheese.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_cheese.Text) * (double.Parse(txtbox_cheese.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_cheese.Text) * (double.Parse(txtbox_cheese.Text) / 100);
                listbox_total.Items.Add(lbl_cheese.Text + "  " + grams + "Kcal");
            }
            if (txtbox_khoa.Text != "")
            {
                calories += Convert.ToDouble(lbl_cal_khoa.Text) * (double.Parse(txtbox_khoa.Text) / 100);
                grams = Convert.ToDouble(lbl_cal_khoa.Text) * (double.Parse(txtbox_khoa.Text) / 100);
                listbox_total.Items.Add(lbl_khoa.Text + "  " + grams + "Kcal");
            }

            txtbox_buffalo.Text = "";
            txtbox_cow.Text = "";
            txtbox_soy.Text = "";
            txtbox_tofu.Text = "";
            txtbox_paneer.Text = "";
            txtbox_cheese.Text = "";
            txtbox_khoa.Text = "";

            lbl_calories.Text = calories.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            listbox_total.Items.Clear();
            calories = 0;
            lbl_calories.Text = calories.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void check_box1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_box1.Checked)
                listbox_total.Visible = true;
            else
                listbox_total.Visible = false;
        }

        //https://www.google.com/amp/s/m.timesofindia.com/life-style/food-news/know-the-calorie-content-of-the-most-common-food-items/amp_etphotostory/81949358.cms
    }
}
