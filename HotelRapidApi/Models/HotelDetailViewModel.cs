namespace HotelRapidApi.Models
{
    public class HotelDetailViewModel
    {


        public bool status { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }
        public Data data { get; set; }
        

        public class Data
        {
            public float ufi { get; set; }
            public float hotel_id { get; set; }
            public string hotel_name { get; set; }
            public string url { get; set; }
            public string hotel_name_trans { get; set; }
            public float review_nr { get; set; }
            public string arrival_date { get; set; }
            public string departure_date { get; set; }
            public string price_transparency_mode { get; set; }
            public string accommodation_type_name { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
            public string address { get; set; }
            public string address_trans { get; set; }
            public string city { get; set; }
            public string city_trans { get; set; }
            public string city_in_trans { get; set; }
            public string city_name_en { get; set; }
            public object district { get; set; }
            public string countrycode { get; set; }
            public float distance_to_cc { get; set; }
            public string default_language { get; set; }
            public string country_trans { get; set; }
            public string currency_code { get; set; }
            public string zip { get; set; }
            public string timezone { get; set; }
            public string rare_find_state { get; set; }
            public float soldout { get; set; }
            public float available_rooms { get; set; }
            public float max_rooms_in_reservation { get; set; }
            public string average_room_size_for_ufi_m2 { get; set; }
            public float is_family_friendly { get; set; }
            public float is_closed { get; set; }
            public float is_crimea { get; set; }
            public float is_hotel_ctrip { get; set; }
            public float is_price_transparent { get; set; }
            public float is_genius_deal { get; set; }
            public float is_cash_accepted_check_enabled { get; set; }
            public float qualifies_for_no_cc_reservation { get; set; }
            public float hotel_include_breakfast { get; set; }
            public string cc1 { get; set; }
            public string[] family_facilities { get; set; }
            public Product_Price_Breakdown product_price_breakdown { get; set; }
            public Composite_Price_Breakdown composite_price_breakdown { get; set; }
            public Property_Highlight_Strip[] property_highlight_strip { get; set; }
            public Facilities_Block facilities_block { get; set; }
            public Top_Ufi_Benefits[] top_ufi_benefits { get; set; }
            public Languages_Spoken languages_spoken { get; set; }
            public string[] spoken_languages { get; set; }
            public Breakfast_Review_Score breakfast_review_score { get; set; }
            public Wifi_Review_Score wifi_review_score { get; set; }
            public Min_Room_Distribution min_room_distribution { get; set; }
            public object[] tax_exceptions { get; set; }
            public Booking_Home booking_home { get; set; }
            public Aggregated_Data aggregated_data { get; set; }
            public Last_Reservation last_reservation { get; set; }
            public Free_Facilities_Cancel_Breakfast[] free_facilities_cancel_breakfast { get; set; }
            public Room_Recommendation[] room_recommendation { get; set; }
            public Hotel_Text hotel_text { get; set; }
            public float[] districts { get; set; }
            public object[] preferences { get; set; }
            public Hotel_Important_Information_With_Codes[] hotel_important_information_with_codes { get; set; }
            public Rooms rooms { get; set; }
            public Block[] block { get; set; }
            public Rawdata rawData { get; set; }
        }

        public class Product_Price_Breakdown
        {
            public All_Inclusive_Amount_Hotel_Currency all_inclusive_amount_hotel_currency { get; set; }
            public Charges_Details charges_details { get; set; }
            public float has_long_stays_monthly_rate_price { get; set; }
            public object[] benefits { get; set; }
            public Gross_Amount gross_amount { get; set; }
            public Included_Taxes_And_Charges_Amount included_taxes_and_charges_amount { get; set; }
            public float has_long_stays_weekly_rate_price { get; set; }
            public Price_Display_Config[] price_display_config { get; set; }
            public Excluded_Amount excluded_amount { get; set; }
            public All_Inclusive_Amount all_inclusive_amount { get; set; }
            public Item[] items { get; set; }
            public float nr_stays { get; set; }
            public Gross_Amount_Hotel_Currency gross_amount_hotel_currency { get; set; }
            public Gross_Amount_Per_Night gross_amount_per_night { get; set; }
            public Net_Amount net_amount { get; set; }
        }

        public class All_Inclusive_Amount_Hotel_Currency
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Charges_Details
        {
            public string mode { get; set; }
            public string translated_copy { get; set; }
            public Amount amount { get; set; }
        }

        public class Amount
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Gross_Amount
        {
            public string amount_unrounded { get; set; }
            public float value { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Included_Taxes_And_Charges_Amount
        {
            public float value { get; set; }
            public string amount_unrounded { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
        }

        public class Excluded_Amount
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class All_Inclusive_Amount
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Gross_Amount_Hotel_Currency
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Gross_Amount_Per_Night
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Net_Amount
        {
            public float value { get; set; }
            public string amount_unrounded { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
        }

        public class Price_Display_Config
        {
            public float value { get; set; }
            public string key { get; set; }
        }

        public class Item
        {
            public Base _base { get; set; }
            public Item_Amount item_amount { get; set; }
            public string name { get; set; }
            public object details { get; set; }
            public string kind { get; set; }
            public string inclusion_type { get; set; }
        }

        public class Base
        {
            public float base_amount { get; set; }
            public string kind { get; set; }
        }

        public class Item_Amount
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Composite_Price_Breakdown
        {
            public Included_Taxes_And_Charges_Amount1 included_taxes_and_charges_amount { get; set; }
            public float has_long_stays_weekly_rate_price { get; set; }
            public Price_Display_Config1[] price_display_config { get; set; }
            public float has_long_stays_monthly_rate_price { get; set; }
            public object[] benefits { get; set; }
            public Gross_Amount1 gross_amount { get; set; }
            public All_Inclusive_Amount_Hotel_Currency1 all_inclusive_amount_hotel_currency { get; set; }
            public Charges_Details1 charges_details { get; set; }
            public Gross_Amount_Per_Night1 gross_amount_per_night { get; set; }
            public Gross_Amount_Hotel_Currency1 gross_amount_hotel_currency { get; set; }
            public Net_Amount1 net_amount { get; set; }
            public Excluded_Amount1 excluded_amount { get; set; }
            public All_Inclusive_Amount1 all_inclusive_amount { get; set; }
            public Item1[] items { get; set; }
        }

        public class Included_Taxes_And_Charges_Amount1
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Gross_Amount1
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class All_Inclusive_Amount_Hotel_Currency1
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public float value { get; set; }
        }

        public class Charges_Details1
        {
            public Amount1 amount { get; set; }
            public string mode { get; set; }
            public string translated_copy { get; set; }
        }

        public class Amount1
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Gross_Amount_Per_Night1
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public float value { get; set; }
        }

        public class Gross_Amount_Hotel_Currency1
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public float value { get; set; }
        }

        public class Net_Amount1
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Excluded_Amount1
        {
            public float value { get; set; }
            public string amount_unrounded { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
        }

        public class All_Inclusive_Amount1
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Price_Display_Config1
        {
            public float value { get; set; }
            public string key { get; set; }
        }

        public class Item1
        {
            public string kind { get; set; }
            public string inclusion_type { get; set; }
            public Base1 _base { get; set; }
            public Item_Amount1 item_amount { get; set; }
            public string name { get; set; }
            public object details { get; set; }
        }

        public class Base1
        {
            public float base_amount { get; set; }
            public string kind { get; set; }
        }

        public class Item_Amount1
        {
            public float value { get; set; }
            public string amount_unrounded { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
        }

        public class Facilities_Block
        {
            public string name { get; set; }
            public string type { get; set; }
            public Facility[] facilities { get; set; }
        }

        public class Facility
        {
            public string icon { get; set; }
            public string name { get; set; }
        }

        public class Languages_Spoken
        {
            public string[] languagecode { get; set; }
        }

        public class Breakfast_Review_Score
        {
            public float review_count { get; set; }
            public float review_number { get; set; }
            public float review_score { get; set; }
            public string review_snippet { get; set; }
            public string review_score_word { get; set; }
            public float rating { get; set; }
        }

        public class Wifi_Review_Score
        {
            public float rating { get; set; }
        }

        public class Min_Room_Distribution
        {
            public float adults { get; set; }
            public object[] children { get; set; }
        }

        public class Booking_Home
        {
        }

        public class Aggregated_Data
        {
            public Common_Kitchen_Fac[] common_kitchen_fac { get; set; }
            public float has_kitchen { get; set; }
            public float has_seating { get; set; }
            public float has_refundable { get; set; }
            public float has_nonrefundable { get; set; }
        }

        public class Common_Kitchen_Fac
        {
            public string name { get; set; }
            public float id { get; set; }
        }

        public class Last_Reservation
        {
            public object country { get; set; }
            public object countrycode { get; set; }
            public string time { get; set; }
        }

        public class Hotel_Text
        {
        }

        public class Rooms
        {
            public _19160509 _19160509 { get; set; }
        }

        public class _19160509
        {
            public Bed_Configurations[] bed_configurations { get; set; }
            public Highlight[] highlights { get; set; }
            public Facility1[] facilities { get; set; }
            public float private_bathroom_count { get; set; }
            public Photo[] photos { get; set; }
            public string description { get; set; }
            public Children_And_Beds_Text children_and_beds_text { get; set; }
            public Private_Bathroom_Highlight private_bathroom_highlight { get; set; }
        }

        public class Children_And_Beds_Text
        {
            public Cribs_And_Extra_Beds[] cribs_and_extra_beds { get; set; }
            public Age_floatervals[] age_floatervals { get; set; }
            public float allow_children { get; set; }
            public Children_At_The_Property[] children_at_the_property { get; set; }
        }

        public class Cribs_And_Extra_Beds
        {
            public float highlight { get; set; }
            public string text { get; set; }
        }

        public class Age_floatervals
        {
            public Group_By_Price group_by_price { get; set; }
            public Crib crib { get; set; }
            public float min_age { get; set; }
            public float max_age { get; set; }
            public string[][] types_by_price { get; set; }
            public Extra_Bed extra_bed { get; set; }
        }

        public class Group_By_Price
        {
            public string[] freeper_night0 { get; set; }
            public string[] fixedper_night2368 { get; set; }
        }

        public class Crib
        {
            public float price { get; set; }
            public float price_mode_n { get; set; }
            public string price_mode { get; set; }
            public float id { get; set; }
            public string price_type { get; set; }
            public float guaranteed { get; set; }
            public float price_type_n { get; set; }
        }

        public class Extra_Bed
        {
            public float price_mode_n { get; set; }
            public string price { get; set; }
            public string price_mode { get; set; }
            public float id { get; set; }
            public string price_type { get; set; }
            public float price_type_n { get; set; }
        }

        public class Children_At_The_Property
        {
            public float highlight { get; set; }
            public string text { get; set; }
        }

        public class Private_Bathroom_Highlight
        {
            public float has_highlight { get; set; }
        }

        public class Bed_Configurations
        {
            public Bed_Types[] bed_types { get; set; }
        }

        public class Bed_Types
        {
            public string name { get; set; }
            public string description { get; set; }
            public float count { get; set; }
            public string name_with_count { get; set; }
            public float bed_type { get; set; }
            public object description_localized { get; set; }
            public string description_imperial { get; set; }
        }

        public class Highlight
        {
            public string translated_name { get; set; }
            public string icon { get; set; }
            public float id { get; set; }
        }

        public class Facility1
        {
            public float alt_facilitytype_id { get; set; }
            public string name { get; set; }
            public float id { get; set; }
            public string alt_facilitytype_name { get; set; }
            public float facilitytype_id { get; set; }
        }

        public class Photo
        {
            public string url_640x200 { get; set; }
            public float photo_id { get; set; }
            public string last_update_date { get; set; }
            public string url_max300 { get; set; }
            public string url_square60 { get; set; }
            public string url_max750 { get; set; }
            public string url_square180 { get; set; }
            public string url_original { get; set; }
            public float ratio { get; set; }
            public string url_max1280 { get; set; }
        }

        public class Rawdata
        {
            public float latitude { get; set; }
            public Checkout checkout { get; set; }
            public float mainPhotoId { get; set; }
            public string currency { get; set; }
            public float accuratePropertyClass { get; set; }
            public bool isFirstPage { get; set; }
            public float longitude { get; set; }
            public float qualityClass { get; set; }
            public float ufi { get; set; }
            public float propertyClass { get; set; }
            public string checkinDate { get; set; }
            public float reviewCount { get; set; }
            public string name { get; set; }
            public float id { get; set; }
            public string[] photoUrls { get; set; }
            public string reviewScoreWord { get; set; }
            public Checkin checkin { get; set; }
            public string checkoutDate { get; set; }
            public float optOutFromGalleryChanges { get; set; }
            public string countryCode { get; set; }
            public float reviewScore { get; set; }
            public float rankingPosition { get; set; }
            public string wishlistName { get; set; }
            public bool isHighlightedHotel { get; set; }
            public Pricebreakdown priceBreakdown { get; set; }
            public float position { get; set; }
            public string[] blockIds { get; set; }
        }

        public class Checkout
        {
            public string untilTime { get; set; }
            public string fromTime { get; set; }
        }

        public class Checkin
        {
            public string fromTime { get; set; }
            public string untilTime { get; set; }
        }

        public class Pricebreakdown
        {
            public Grossprice grossPrice { get; set; }
            public object[] taxExceptions { get; set; }
            public object[] benefitBadges { get; set; }
            public string chargesInfo { get; set; }
        }

        public class Grossprice
        {
            public float value { get; set; }
            public string currency { get; set; }
            public string amountRounded { get; set; }
        }

        public class Property_Highlight_Strip
        {
            public string name { get; set; }
            public Icon_List[] icon_list { get; set; }
        }

        public class Icon_List
        {
            public float size { get; set; }
            public string icon { get; set; }
        }

        public class Top_Ufi_Benefits
        {
            public string icon { get; set; }
            public string translated_name { get; set; }
        }

        public class Free_Facilities_Cancel_Breakfast
        {
            public float facility_id { get; set; }
        }

        public class Room_Recommendation
        {
            public float number_of_extra_beds_for_adults { get; set; }
            public float adults { get; set; }
            public float total_extra_bed_price_in_hotel_currency { get; set; }
            public float extra_beds_for_children_price_in_hotel_currency { get; set; }
            public float number_of_extra_beds_for_children { get; set; }
            public float extra_babycots_price_in_hotel_currency { get; set; }
            public float babies { get; set; }
            public float extra_beds_for_children_price { get; set; }
            public float extra_babycots_price { get; set; }
            public float children { get; set; }
            public float extra_beds_for_adults_price_in_hotel_currency { get; set; }
            public float total_extra_bed_price { get; set; }
            public float extra_beds_for_adults_price { get; set; }
            public float number_of_extra_babycots { get; set; }
            public string block_id { get; set; }
            public float number_of_extra_beds_and_babycots_total { get; set; }
        }

        public class Hotel_Important_Information_With_Codes
        {
            public float sentence_id { get; set; }
            public string phrase { get; set; }
            public float executing_phase { get; set; }
        }

        public class Block
        {
            public float is_last_minute_deal { get; set; }
            public string mealplan { get; set; }
            public float half_board { get; set; }
            public float room_surface_in_feet2 { get; set; }
            public float full_board { get; set; }
            public object extrabed_available_amount { get; set; }
            public Paymentterms paymentterms { get; set; }
            public float room_id { get; set; }
            public string name_without_policy { get; set; }
            public string max_occupancy { get; set; }
            public float is_flash_deal { get; set; }
            public float room_surface_in_m2 { get; set; }
            public float deposit_required { get; set; }
            public float breakfast_included { get; set; }
            public float nr_children { get; set; }
            public float max_children_free { get; set; }
            public string refundable_until { get; set; }
            public string room_name { get; set; }
            public string is_block_fit { get; set; }
            public float is_domestic_rate { get; set; }
            public object[] children_ages { get; set; }
            public float is_smart_deal { get; set; }
            public float number_of_bathrooms { get; set; }
            public float room_count { get; set; }
            public float smoking { get; set; }
            public Block_Text block_text { get; set; }
            public float all_inclusive { get; set; }
            public object babycots_available_amount { get; set; }
            public object[] bh_room_highlights { get; set; }
            public float can_reserve_free_parking { get; set; }
            public float nr_adults { get; set; }
            public float package_id { get; set; }
            public float genius_discount_percentage { get; set; }
            public float refundable { get; set; }
            public string block_id { get; set; }
            public float fit_status { get; set; }
            public float must_reserve_free_parking { get; set; }
            public string name { get; set; }
            public Fit_Occupancy fit_occupancy { get; set; }
            public float babycots_available { get; set; }
            public float number_of_bedrooms { get; set; }
            public float roomtype_id { get; set; }
            public float pod_ios_migrate_policies_to_smp_fullon { get; set; }
            public float max_children_free_age { get; set; }
            public float extrabed_available { get; set; }
            public object is_genius_deal { get; set; }
        }

        public class Paymentterms
        {
            public Prepayment prepayment { get; set; }
            public Cancellation cancellation { get; set; }
        }

        public class Prepayment
        {
            public string type_translation { get; set; }
            public string simple_translation { get; set; }
            public Info info { get; set; }
            public string description { get; set; }
            public string type_extended { get; set; }
            public Timeline timeline { get; set; }
            public string type { get; set; }
            public string extended_type_translation { get; set; }
        }

        public class Info
        {
            public object date_before { get; set; }
            public float prepayment_at_booktime { get; set; }
            public object timezone { get; set; }
            public object timezone_offset { get; set; }
            public string refundable { get; set; }
            public object time { get; set; }
            public object is_midnight { get; set; }
            public object date { get; set; }
            public object time_before_midnight { get; set; }
        }

        public class Timeline
        {
            public float nr_stages { get; set; }
            public string policygroup_instance_id { get; set; }
            public string u_currency_code { get; set; }
            public Stage[] stages { get; set; }
            public string currency_code { get; set; }
        }

        public class Stage
        {
            public string amount { get; set; }
            public string text { get; set; }
            public string fee_pretty { get; set; }
            public string limit_from_raw { get; set; }
            public float fee_rounded { get; set; }
            public string u_fee_remaining_pretty { get; set; }
            public string stage_fee_pretty { get; set; }
            public string u_stage_fee { get; set; }
            public string limit_until_time { get; set; }
            public string limit_until_raw { get; set; }
            public string limit_until { get; set; }
            public float fee { get; set; }
            public float stage_fee { get; set; }
            public string limit_from_date { get; set; }
            public float is_free { get; set; }
            public float is_effective { get; set; }
            public string u_stage_fee_pretty { get; set; }
            public float fee_remaining { get; set; }
            public string u_fee_pretty { get; set; }
            public float b_number { get; set; }
            public string limit_from { get; set; }
            public string u_fee_remaining { get; set; }
            public string u_fee { get; set; }
            public string limit_from_time { get; set; }
            public string amount_pretty { get; set; }
            public float effective_number { get; set; }
            public string b_state { get; set; }
            public float current_stage { get; set; }
            public string limit_timezone { get; set; }
            public string limit_until_date { get; set; }
            public string fee_remaining_pretty { get; set; }
            public float after_checkin { get; set; }
        }

        public class Cancellation
        {
            public string description { get; set; }
            public Info1 info { get; set; }
            public Timeline1 timeline { get; set; }
            public float non_refundable_anymore { get; set; }
            public string type { get; set; }
            public float guaranteed_non_refundable { get; set; }
            public string type_translation { get; set; }
            public string bucket { get; set; }
        }

        public class Info1
        {
            public object refundable_date { get; set; }
            public object date { get; set; }
            public object time_before_midnight { get; set; }
            public object timezone_offset { get; set; }
            public object time { get; set; }
            public object timezone { get; set; }
            public object date_before_raw { get; set; }
            public object date_before { get; set; }
            public object is_midnight { get; set; }
            public object date_raw { get; set; }
            public float refundable { get; set; }
        }

        public class Timeline1
        {
            public string currency_code { get; set; }
            public string u_currency_code { get; set; }
            public Stage1[] stages { get; set; }
            public string policygroup_instance_id { get; set; }
            public float nr_stages { get; set; }
        }

        public class Stage1
        {
            public string text_refundable { get; set; }
            public float fee_rounded { get; set; }
            public string fee_pretty { get; set; }
            public string limit_from_raw { get; set; }
            public string stage_fee_pretty { get; set; }
            public string u_stage_fee { get; set; }
            public string u_fee_remaining_pretty { get; set; }
            public float amount { get; set; }
            public string text { get; set; }
            public float is_free { get; set; }
            public float is_effective { get; set; }
            public string u_stage_fee_pretty { get; set; }
            public float fee_remaining { get; set; }
            public string limit_until_raw { get; set; }
            public string limit_until { get; set; }
            public string limit_until_time { get; set; }
            public string limit_from_date { get; set; }
            public string stage_translation { get; set; }
            public float fee { get; set; }
            public float stage_fee { get; set; }
            public string amount_pretty { get; set; }
            public string u_fee_remaining { get; set; }
            public string limit_from { get; set; }
            public string u_fee { get; set; }
            public string limit_from_time { get; set; }
            public float current_stage { get; set; }
            public string b_state { get; set; }
            public float effective_number { get; set; }
            public string u_fee_pretty { get; set; }
            public float b_number { get; set; }
            public string limit_until_date { get; set; }
            public string fee_remaining_pretty { get; set; }
            public string limit_timezone { get; set; }
        }

        public class Block_Text
        {
            public Policy[] policies { get; set; }
        }

        public class Policy
        {
            public string content { get; set; }
            public string _class { get; set; }
            public string mealplan_vector { get; set; }
        }

        public class Fit_Occupancy
        {
            public float nr_adults { get; set; }
            public object[] children_ages { get; set; }
        }

    }
}