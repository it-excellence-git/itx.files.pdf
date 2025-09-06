using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace itx.edifact
{
    /// <summary>
    /// Text subject codes for various document and transaction types.
    /// </summary>
    public enum TextSubjectCodes
    {
        /// <summary>
        /// [7002] Plain language description of the nature of the goods sufficient to identify them at the level required for banking, Customs, statistical or transport purposes, avoiding unnecessary detail (Generic term).
        /// </summary>
        AAA,

        /// <summary>
        /// [4276] Conditions of payment between the parties to a transaction (generic term).
        /// </summary>
        AAB,

        /// <summary>
        /// Additional information concerning dangerous goods.
        /// </summary>
        AAC,

        /// <summary>
        /// Proper shipping name, supplemented as necessary with the correct technical name, by which a dangerous substance or article may be correctly identified or which is sufficiently informative to permit identification by reference to generally available literature.
        /// </summary>
        AAD,

        /// <summary>
        /// The content of an acknowledgement.
        /// </summary>
        AAE,

        /// <summary>
        /// Specific details applying to rates.
        /// </summary>
        AAF,

        /// <summary>
        /// Indicates that the segment contains instructions to be passed on to the identified party.
        /// </summary>
        AAG,

        /// <summary>
        /// [4034] Information entered by Customs on the CIM.
        /// </summary>
        AAH,

        /// <summary>
        /// The text contains general information.
        /// </summary>
        AAI,

        /// <summary>
        /// Additional conditions specific to this order or project.
        /// </summary>
        AAJ,

        /// <summary>
        /// Information on the price conditions that are expected or given.
        /// </summary>
        AAK,

        /// <summary>
        /// Expression of a number in characters as length of ten meters.
        /// </summary>
        AAL,

        /// <summary>
        /// Technical or commercial reasons why a piece of equipment may not be re-used after the current transport terminates.
        /// </summary>
        AAM,

        /// <summary>
        /// Restrictions in handling depending on the technical characteristics of the piece of equipment or on the nature of the goods.
        /// </summary>
        AAN,

        /// <summary>
        /// Error described by a free text.
        /// </summary>
        AAO,

        /// <summary>
        /// Free text of the response to a communication.
        /// </summary>
        AAP,

        /// <summary>
        /// A description of the contents of a package.
        /// </summary>
        AAQ,

        /// <summary>
        /// (4053) Free text of the non Incoterms terms of delivery. For Incoterms, use: 4053.
        /// </summary>
        AAR,

        /// <summary>
        /// The remarks printed or to be printed on a bill of lading.
        /// </summary>
        AAS,

        /// <summary>
        /// Free text information on an IATA Air Waybill to indicate means by which account is to be settled.
        /// </summary>
        AAT,

        /// <summary>
        /// Information pertaining to the invoice covering the consignment.
        /// </summary>
        AAU,

        /// <summary>
        /// Information pertaining to the invoice covering clearance of the cargo.
        /// </summary>
        AAV,

        /// <summary>
        /// Information pertaining to the letter of credit.
        /// </summary>
        AAW,

        /// <summary>
        /// Information pertaining to a license.
        /// </summary>
        AAX,

        /// <summary>
        /// The text contains certification statements.
        /// </summary>
        AAY,

        /// <summary>
        /// The text contains additional export information.
        /// </summary>
        AAZ,

        /// <summary>
        /// Description of parameters relating to a tariff.
        /// </summary>
        ABA,

        /// <summary>
        /// Historical details of a patients medical events.
        /// </summary>
        ABB,

        /// <summary>
        /// Additional information regarding terms and conditions which apply to the transaction.
        /// </summary>
        ABC,

        /// <summary>
        /// An indication for customs of the type of contract under which goods are supplied.
        /// </summary>
        ABD,

        /// <summary>
        /// Additional terms and/or conditions to the documentary credit.
        /// </summary>
        ABE,

        /// <summary>
        /// Instruction or information about a standby documentary credit.
        /// </summary>
        ABF,

        /// <summary>
        /// Instructions or information about partial shipment(s).
        /// </summary>
        ABG,

        /// <summary>
        /// Instructions or information about transhipment(s).
        /// </summary>
        ABH,

        /// <summary>
        /// Additional handling instructions for a documentary credit.
        /// </summary>
        ABI,

        /// <summary>
        /// Information regarding the domestic routing.
        /// </summary>
        ABJ,

        /// <summary>
        /// Equipment types are coded by category for financial purposes.
        /// </summary>
        ABK,

        /// <summary>
        /// Information pertaining to government.
        /// </summary>
        ABL,

        /// <summary>
        /// The text contains onward routing information.
        /// </summary>
        ABM,

        /// <summary>
        /// The text contains information related to accounting.
        /// </summary>
        ABN,

        /// <summary>
        /// Free text or coded information to indicate a specific discrepancy.
        /// </summary>
        ABO,

        /// <summary>
        /// Documentary credit confirmation instructions.
        /// </summary>
        ABP,

        /// <summary>
        /// Method of issuance of documentary credit.
        /// </summary>
        ABQ,

        /// <summary>
        /// Delivery instructions for documents required under a documentary credit.
        /// </summary>
        ABR,

        /// <summary>
        /// Additional conditions to the issuance of a documentary credit.
        /// </summary>
        ABS,

        /// <summary>
        /// Additional amounts information/instruction.
        /// </summary>
        ABT,

        /// <summary>
        /// Additional terms concerning deferred payment.
        /// </summary>
        ABU,

        /// <summary>
        /// Additional terms concerning acceptance.
        /// </summary>
        ABV,

        /// <summary>
        /// Additional terms concerning negotiation.
        /// </summary>
        ABW,

        /// <summary>
        /// Document name and documentary requirements.
        /// </summary>
        ABX,

        /// <summary>
        /// Regulatory information. The free text contains information for regulatory authority. Note: 1. This code value will be removed effective with directory D.02B.
        /// </summary>
        ABY,

        /// <summary>
        /// Instructions/information about a revolving documentary credit.
        /// </summary>
        ABZ,

        /// <summary>
        /// Specification of the documentary requirements.
        /// </summary>
        ACA,

        /// <summary>
        /// The text contains additional information.
        /// </summary>
        ACB,

        /// <summary>
        /// Assignment based on an agreement between seller and factor.
        /// </summary>
        ACC,

        /// <summary>
        /// Reason for a request or response.
        /// </summary>
        ACD,

        /// <summary>
        /// A notice, usually from buyer to seller, that something was found wrong with goods delivered or the services rendered, or with the related invoice.
        /// </summary>
        ACE,

        /// <summary>
        /// The text refers to information about an additional attribute not otherwise specified.
        /// </summary>
        ACF,

        /// <summary>
        /// A declaration on the reason of the absence.
        /// </summary>
        ACG,

        /// <summary>
        /// A statement on the way a specific variable or set of variables has been aggregated.
        /// </summary>
        ACH,

        /// <summary>
        /// A statement on the compilation status of an array or other set of figures or calculations.
        /// </summary>
        ACI,

        /// <summary>
        /// An exception to the agreed definition of a term, concept, formula or other object.
        /// </summary>
        ACJ,

        /// <summary>
        /// A statement on the privacy or confidential nature of an object.
        /// </summary>
        ACK,

        /// <summary>
        /// A statement on the quality of an object.
        /// </summary>
        ACL,

        /// <summary>
        /// The description of a statistical object such as a value list, concept, or structure definition.
        /// </summary>
        ACM,

        /// <summary>
        /// The definition of a statistical object such as a value list, concept, or structure definition.
        /// </summary>
        ACN,

        /// <summary>
        /// The name of a statistical object such as a value list, concept or structure definition.
        /// </summary>
        ACO,

        /// <summary>
        /// The title of a statistical object such as a value list, concept, or structure definition.
        /// </summary>
        ACP,

        /// <summary>
        /// Information relating to differences between the actual transport dimensions and the normally applicable dimensions.
        /// </summary>
        ACQ,

        /// <summary>
        /// Information relating to unexpected stops during a conveyance.
        /// </summary>
        ACR,

        /// <summary>
        /// Text subject is principles section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
        /// </summary>
        ACS,

        /// <summary>
        /// Text subject is terms and definition section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
        /// </summary>
        ACT,

        /// <summary>
        /// Text subject is segment name.
        /// </summary>
        ACU,

        /// <summary>
        /// Text subject is name of simple data element.
        /// </summary>
        ACV,

        /// <summary>
        /// Text subject is scope section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
        /// </summary>
        ACW,

        /// <summary>
        /// Text subject is name of message type.
        /// </summary>
        ACX,

        /// <summary>
        /// Text subject is introduction section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
        /// </summary>
        ACY,

        /// <summary>
        /// Text subject is glossary section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
        /// </summary>
        ACZ,

        /// <summary>
        /// Text subject is functional definition section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
        /// </summary>
        ADA,

        /// <summary>
        /// Text subject is examples as given in the example(s) section of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
        /// </summary>
        ADB,

        /// <summary>
        /// Text subject is cover page of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
        /// </summary>
        ADC,

        /// <summary>
        /// Denotes that the associated text is a dependency (syntax) note.
        /// </summary>
        ADD,

        /// <summary>
        /// Text subject is name of code value.
        /// </summary>
        ADE,

        /// <summary>
        /// Text subject is name of code list.
        /// </summary>
        ADF,

        /// <summary>
        /// Text subject is an explanation of the intended usage of a segment or segment group.
        /// </summary>
        ADG,

        /// <summary>
        /// Text subject is name of composite data element.
        /// </summary>
        ADH,

        /// <summary>
        /// Text subject is field of application of the UN/EDIFACT rules for presentation of standardized message and directories documentation.
        /// </summary>
        ADI,

        /// <summary>
        /// Information describing the type of assets and liabilities.
        /// </summary>
        ADJ,

        /// <summary>
        /// The text contains information about a promotion.
        /// </summary>
        ADK,

        /// <summary>
        /// Description of the condition of a meter.
        /// </summary>
        ADL,

        /// <summary>
        /// Information related to a particular reading of a meter.
        /// </summary>
        ADM,

        /// <summary>
        /// Information describing the type of the reason of transaction.
        /// </summary>
        ADN,

        /// <summary>
        /// Type of survey question.
        /// </summary>
        ADO,

        /// <summary>
        /// Information for use at the counter of the carrier's agent.
        /// </summary>
        ADP,

        /// <summary>
        /// Description or code for the operation to be executed on the equipment.
        /// </summary>
        ADQ,

        /// <summary>
        /// Text subject is message definition.
        /// </summary>
        ADR,

        /// <summary>
        /// Information pertaining to a booked item.
        /// </summary>
        ADS,

        /// <summary>
        /// Text subject is source of document.
        /// </summary>
        ADT,

        /// <summary>
        /// Text subject is note.
        /// </summary>
        ADU,

        /// <summary>
        /// Text subject is fixed part of segment clarification text.
        /// </summary>
        ADV,

        /// <summary>
        /// Description of the characteristics of goods in addition to the description of the goods [7002].
        /// </summary>
        ADW,

        /// <summary>
        /// Special discharge instructions concerning the goods.
        /// </summary>
        ADX,

        /// <summary>
        /// Instructions regarding the stripping of container(s).
        /// </summary>
        ADY,

        /// <summary>
        /// Information on the CSC (Container Safety Convention) plate that is attached to the container.
        /// </summary>
        ADZ,

        /// <summary>
        /// Additional remarks concerning the cargo.
        /// </summary>
        AEA,

        /// <summary>
        /// Instruction regarding the temperature control of the cargo.
        /// </summary>
        AEB,

        /// <summary>
        /// Remarks refer to data that was expected.
        /// </summary>
        AEC,

        /// <summary>
        /// Remarks refer to data that was received.
        /// </summary>
        AED,

        /// <summary>
        /// Text subject is section clarification text.
        /// </summary>
        AEE,

        /// <summary>
        /// Information given to the beneficiary.
        /// </summary>
        AEF,

        /// <summary>
        /// Information given to the applicant.
        /// </summary>
        AEG,

        /// <summary>
        /// Instructions made to the beneficiary.
        /// </summary>
        AEH,

        /// <summary>
        /// Instructions given to the applicant.
        /// </summary>
        AEI,

        /// <summary>
        /// Information about the controlled atmosphere.
        /// </summary>
        AEJ,

        /// <summary>
        /// Additional information in plain text to support a take off annotation.
        /// </summary>
        AEK,

        /// <summary>
        /// Additional information in plain language to support a price variation.
        /// </summary>
        AEL,

        /// <summary>
        /// Documentary credit amendment instructions.
        /// </summary>
        AEM,

        /// <summary>
        /// Additional information in plain language to support a standard method.
        /// </summary>
        AEN,

        /// <summary>
        /// Additional information in plain language to support the project.
        /// </summary>
        AEO,

        /// <summary>
        /// Additional information related to radioactive goods.
        /// </summary>
        AEP,

        /// <summary>
        /// Information given from one bank to another.
        /// </summary>
        AEQ,

        /// <summary>
        /// Instructions given for reimbursement purposes.
        /// </summary>
        AER,

        /// <summary>
        /// Identification of the reason for amending a message.
        /// </summary>
        AES,

        /// <summary>
        /// Instructions to the paying and/or accepting and/or negotiating bank.
        /// </summary>
        AET,

        /// <summary>
        /// Instructions given about the interest.
        /// </summary>
        AEU,

        /// <summary>
        /// Instructions about agent commission.
        /// </summary>
        AEV,

        /// <summary>
        /// Instructions to the remitting bank.
        /// </summary>
        AEW,

        /// <summary>
        /// Instructions to the bank, other than the remitting bank, involved in processing the collection.
        /// </summary>
        AEX,

        /// <summary>
        /// Instructions about the collection amount.
        /// </summary>
        AEY,

        /// <summary>
        /// Text relating to internal auditing information.
        /// </summary>
        AEZ,

        /// <summary>
        /// Denotes that the associated text is a constraint.
        /// </summary>
        AFA,

        /// <summary>
        /// Denotes that the associated text is a comment.
        /// </summary>
        AFB,

        /// <summary>
        /// Denotes that the associated text is a semantic note.
        /// </summary>
        AFC,

        /// <summary>
        /// Denotes that the associated text is an item of help text.
        /// </summary>
        AFD,

        /// <summary>
        /// Denotes that the associated text is a legend.
        /// </summary>
        AFE,

        /// <summary>
        /// A description of the structure of a batch code.
        /// </summary>
        AFF,

        /// <summary>
        /// A general description of the application of a product.
        /// </summary>
        AFG,

        /// <summary>
        /// Complaint of customer.
        /// </summary>
        AFH,

        /// <summary>
        /// The probable cause of fault.
        /// </summary>
        AFI,

        /// <summary>
        /// Description of the defect.
        /// </summary>
        AFJ,

        /// <summary>
        /// The description of the work performed during the repair.
        /// </summary>
        AFK,

        /// <summary>
        /// Comments relevant to a review.
        /// </summary>
        AFL,

        /// <summary>
        /// Denotes that the associated text is a title.
        /// </summary>
        AFM,

        /// <summary>
        /// An amount description in clear text.
        /// </summary>
        AFN,

        /// <summary>
        /// Information describing the responsibilities.
        /// </summary>
        AFO,

        /// <summary>
        /// Information concerning suppliers.
        /// </summary>
        AFP,

        /// <summary>
        /// Information concerning the region(s) where purchases are made.
        /// </summary>
        AFQ,

        /// <summary>
        /// Information concerning an association of one party with another party(ies).
        /// </summary>
        AFR,

        /// <summary>
        /// Information concerning the borrower.
        /// </summary>
        AFS,

        /// <summary>
        /// Information concerning an entity's line of business.
        /// </summary>
        AFT,

        /// <summary>
        /// Description of financial institution(s) used by an entity.
        /// </summary>
        AFU,

        /// <summary>
        /// Information about the business founder.
        /// </summary>
        AFV,

        /// <summary>
        /// Description of the business history.
        /// </summary>
        AFW,

        /// <summary>
        /// Information concerning the general banking arrangements.
        /// </summary>
        AFX,

        /// <summary>
        /// Description of the business origin.
        /// </summary>
        AFY,

        /// <summary>
        /// Description of the entity's brands.
        /// </summary>
        AFZ,

        /// <summary>
        /// Details about the financing of the business.
        /// </summary>
        AGA,

        /// <summary>
        /// Information concerning an entity's competition.
        /// </summary>
        AGB,

        /// <summary>
        /// Details about the construction process.
        /// </summary>
        AGC,

        /// <summary>
        /// Information concerning the line of business of a construction entity.
        /// </summary>
        AGD,

        /// <summary>
        /// Details about contract(s).
        /// </summary>
        AGE,

        /// <summary>
        /// Details about a corporate filing.
        /// </summary>
        AGF,

        /// <summary>
        /// Description of customers.
        /// </summary>
        AGG,

        /// <summary>
        /// Information concerning the copyright notice.
        /// </summary>
        AGH,

        /// <summary>
        /// Details about the contingent debt.
        /// </summary>
        AGI,

        /// <summary>
        /// Details about the law or penal codes that resulted in conviction.
        /// </summary>
        AGJ,

        /// <summary>
        /// Description of equipment.
        /// </summary>
        AGK,

        /// <summary>
        /// Comments about the workforce.
        /// </summary>
        AGL,

        /// <summary>
        /// Description about exemptions.
        /// </summary>
        AGM,

        /// <summary>
        /// Information on future plans.
        /// </summary>
        AGN,

        /// <summary>
        /// Information concerning the interviewee conversation.
        /// </summary>
        AGO,

        /// <summary>
        /// Description of intangible asset(s).
        /// </summary>
        AGP,

        /// <summary>
        /// Description of the inventory.
        /// </summary>
        AGQ,

        /// <summary>
        /// Description of the investments.
        /// </summary>
        AGR,

        /// <summary>
        /// Description of the intercompany relations.
        /// </summary>
        AGS,

        /// <summary>
        /// Description of the joint venture.
        /// </summary>
        AGT,

        /// <summary>
        /// Description of a loan.
        /// </summary>
        AGU,

        /// <summary>
        /// Description of the long term debt.
        /// </summary>
        AGV,

        /// <summary>
        /// Description of a location.
        /// </summary>
        AGW,

        /// <summary>
        /// Details on the current legal structure.
        /// </summary>
        AGX,

        /// <summary>
        /// Details on a marital contract.
        /// </summary>
        AGY,

        /// <summary>
        /// Information concerning marketing activities.
        /// </summary>
        AGZ,

        /// <summary>
        /// Description of a merger.
        /// </summary>
        AHA,

        /// <summary>
        /// Description of the marketable securities.
        /// </summary>
        AHB,

        /// <summary>
        /// Description of the business debt(s).
        /// </summary>
        AHC,

        /// <summary>
        /// Information concerning the original legal structure.
        /// </summary>
        AHD,

        /// <summary>
        /// Information describing how a company uses employees from another company.
        /// </summary>
        AHE,

        /// <summary>
        /// Description about the organization of a company.
        /// </summary>
        AHF,

        /// <summary>
        /// Information concerning public records.
        /// </summary>
        AHG,

        /// <summary>
        /// Information concerning the price range of products made or sold.
        /// </summary>
        AHH,

        /// <summary>
        /// Information on the accomplishments fitting a party for a position.
        /// </summary>
        AHI,

        /// <summary>
        /// Information concerning the registered activity.
        /// </summary>
        AHJ,

        /// <summary>
        /// Description of the sentence imposed in a criminal proceeding.
        /// </summary>
        AHK,

        /// <summary>
        /// Description of the selling means.
        /// </summary>
        AHL,

        /// <summary>
        /// Free form description relating to the school(s) attended.
        /// </summary>
        AHM,

        /// <summary>
        /// Describes the status details.
        /// </summary>
        AHN,

        /// <summary>
        /// Description of the sales.
        /// </summary>
        AHO,

        /// <summary>
        /// Information about the spouse.
        /// </summary>
        AHP,

        /// <summary>
        /// Details about the educational degree received from a school.
        /// </summary>
        AHQ,

        /// <summary>
        /// General description of shareholding.
        /// </summary>
        AHR,

        /// <summary>
        /// Information on the sales territory.
        /// </summary>
        AHS,

        /// <summary>
        /// Comments made by an accountant regarding a financial statement.
        /// </summary>
        AHT,

        /// <summary>
        /// Description of the exemption provided to a location by a law.
        /// </summary>
        AHU,

        /// <summary>
        /// Information about the classes or categories of shares.
        /// </summary>
        AHV,

        /// <summary>
        /// Description of a prediction.
        /// </summary>
        AHW,

        /// <summary>
        /// Description of the location of an event.
        /// </summary>
        AHX,

        /// <summary>
        /// Information related to occupancy of a facility.
        /// </summary>
        AHY,

        /// <summary>
        /// Specific information provided about the importation and exportation of goods.
        /// </summary>
        AHZ,

        /// <summary>
        /// Additional information about a facility.
        /// </summary>
        AIA,

        /// <summary>
        /// Description of the value of inventory.
        /// </summary>
        AIB,

        /// <summary>
        /// Description of the education of a person.
        /// </summary>
        AIC,

        /// <summary>
        /// Description of a thing that happens or takes place.
        /// </summary>
        AID,

        /// <summary>
        /// Information about agents the entity uses.
        /// </summary>
        AIE,

        /// <summary>
        /// Details of domestically agreed financial statement.
        /// </summary>
        AIF,

        /// <summary>
        /// Description of other current asset.
        /// </summary>
        AIG,

        /// <summary>
        /// Description of other current liability.
        /// </summary>
        AIH,

        /// <summary>
        /// Description of the former line of business.
        /// </summary>
        AII,

        /// <summary>
        /// Description of how a trading name is used.
        /// </summary>
        AIJ,

        /// <summary>
        /// Description of the authorized signatory.
        /// </summary>
        AIK,

        /// <summary>
        /// Description of guarantee.
        /// </summary>
        AIL,

        /// <summary>
        /// Description of the operation of a holding company.
        /// </summary>
        AIM,

        /// <summary>
        /// Information on routing of the consignment.
        /// </summary>
        AIN,

        /// <summary>
        /// A letter citing any condition in dispute.
        /// </summary>
        AIO,

        /// <summary>
        /// A free text question.
        /// </summary>
        AIP,

        /// <summary>
        /// Free text information related to a party.
        /// </summary>
        AIQ,

        /// <summary>
        /// Description of the boundaries of a geographical area.
        /// </summary>
        AIR,

        /// <summary>
        /// The free text contains advertisement information.
        /// </summary>
        AIS,

        /// <summary>
        /// Details regarding the financial statement in free text.
        /// </summary>
        AIT,

        /// <summary>
        /// Description of how to access an entity.
        /// </summary>
        AIU,

        /// <summary>
        /// Description of an entity's liquidity.
        /// </summary>
        AIV,

        /// <summary>
        /// Description of the line of credit available to an entity.
        /// </summary>
        AIW,

        /// <summary>
        /// Text describing the terms of warranty which apply to a product or service.
        /// </summary>
        AIX,

        /// <summary>
        /// Plain language description of a division of an entity.
        /// </summary>
        AIY,

        /// <summary>
        /// Instruction on how to report.
        /// </summary>
        AIZ,

        /// <summary>
        /// The result of an examination.
        /// </summary>
        AJA,

        /// <summary>
        /// The result of a laboratory investigation.
        /// </summary>
        AJB,

        /// <summary>
        /// Information referring to allowance/charge.
        /// </summary>
        ALC,

        /// <summary>
        /// The result of an X-ray examination.
        /// </summary>
        ALD,

        /// <summary>
        /// The result of a pathology investigation.
        /// </summary>
        ALE,

        /// <summary>
        /// Details of an intervention.
        /// </summary>
        ALF,

        /// <summary>
        /// Summary description of admittance.
        /// </summary>
        ALG,

        /// <summary>
        /// Details of a course of medical treatment.
        /// </summary>
        ALH,

        /// <summary>
        /// Details of a prognosis.
        /// </summary>
        ALI,

        /// <summary>
        /// Instruction given to a patient.
        /// </summary>
        ALJ,

        /// <summary>
        /// Instruction given to a physician.
        /// </summary>
        ALK,

        /// <summary>
        /// The note implies to all documents.
        /// </summary>
        ALL,

        /// <summary>
        /// Details of medicine treatment.
        /// </summary>
        ALM,

        /// <summary>
        /// Details of medicine dosage and method of administration.
        /// </summary>
        ALN,

        /// <summary>
        /// Details of when and/or where the patient is available.
        /// </summary>
        ALO,

        /// <summary>
        /// Details of the reason for a requested service.
        /// </summary>
        ALP,

        /// <summary>
        /// Details of the purpose of a service.
        /// </summary>
        ALQ,

        /// <summary>
        /// Conditions under which arrival takes place.
        /// </summary>
        ARR,

        /// <summary>
        /// Comment by the requester of a service.
        /// </summary>
        ARS,

        /// <summary>
        /// Name, code, password etc. given for authentication purposes.
        /// </summary>
        AUT,

        /// <summary>
        /// The description of the location requested.
        /// </summary>
        AUU,

        /// <summary>
        /// The event or condition that initiates the administration of a single dose of medicine or a period of treatment.
        /// </summary>
        AUV,

        /// <summary>
        /// Information concerning a patient.
        /// </summary>
        AUW,

        /// <summary>
        /// Action to be taken to avert possible harmful affects.
        /// </summary>
        AUX,

        /// <summary>
        /// Free text description is related to a service characteristic.
        /// </summary>
        AUY,

        /// <summary>
        /// Comment about an event that is planned.
        /// </summary>
        AUZ,

        /// <summary>
        /// Comment about the expected delay.
        /// </summary>
        AVA,

        /// <summary>
        /// Comment about the requirements for transport.
        /// </summary>
        AVB,

        /// <summary>
        /// Clause on the bill of lading regarding the cargo being shipped.
        /// </summary>
        BLC,

        /// <summary>
        /// Instruction with the purpose of preparing the patient.
        /// </summary>
        BLD,

        /// <summary>
        /// Comment about treatment with medicine.
        /// </summary>
        BLE,

        /// <summary>
        /// Comment about the result of an examination.
        /// </summary>
        BLF,

        /// <summary>
        /// Comment about the requested service.
        /// </summary>
        BLG,

        /// <summary>
        /// Details of the reason for a prescription.
        /// </summary>
        BLH,

        /// <summary>
        /// Comment concerning a specified prescription.
        /// </summary>
        BLI,

        /// <summary>
        /// Comment concerning a clinical investigation.
        /// </summary>
        BLJ,

        /// <summary>
        /// Comment concerning the specification of a medicinal product.
        /// </summary>
        BLK,

        /// <summary>
        /// Comment concerning economic contribution.
        /// </summary>
        BLL,

        /// <summary>
        /// Comment about the status of a plan.
        /// </summary>
        BLM,

        /// <summary>
        /// Information regarding a random sample test.
        /// </summary>
        BLN,

        /// <summary>
        /// Text subject is a period of time.
        /// </summary>
        BLO,

        /// <summary>
        /// Information about legislation.
        /// </summary>
        BLP,

        /// <summary>
        /// Remarks concerning the complete consignment to be printed on the bill of lading.
        /// </summary>
        BLR,

        /// <summary>
        /// Any coded or clear instruction agreed by customer and carrier regarding the declaration of the goods.
        /// </summary>
        CCI,

        /// <summary>
        /// Any coded or clear instruction agreed by customer and carrier regarding the export declaration of the goods.
        /// </summary>
        CEX,

        /// <summary>
        /// Note contains change information.
        /// </summary>
        CHG,

        /// <summary>
        /// Any coded or clear instruction agreed by customer and carrier regarding the import declaration of the goods.
        /// </summary>
        CIP,

        /// <summary>
        /// Name of the place where Customs clearance is asked to be executed as requested by the consignee/consignor.
        /// </summary>
        CLP,

        /// <summary>
        /// Instructions concerning the loading of the container.
        /// </summary>
        CLR,

        /// <summary>
        /// Additional information related to an order.
        /// </summary>
        COI,

        /// <summary>
        /// Remarks from or for a supplier of goods or services.
        /// </summary>
        CUR,

        /// <summary>
        /// Note contains customs declaration information.
        /// </summary>
        CUS,

        /// <summary>
        /// Remarks concerning damage on the cargo.
        /// </summary>
        DAR,

        /// <summary>
        /// [4020] Text of a declaration made by the issuer of the document (CIM 12).
        /// </summary>
        DCL,

        /// <summary>
        /// Information about delivery.
        /// </summary>
        DEL,

        /// <summary>
        /// Instructions regarding the delivery of the cargo.
        /// </summary>
        DIN,

        /// <summary>
        /// Instructions pertaining to the documentation.
        /// </summary>
        DOC,

        /// <summary>
        /// The text contains a statement constituting a duty declaration.
        /// </summary>
        DUT,

        /// <summary>
        /// Physical route effectively used for the movement of the means of transport.
        /// </summary>
        EUR,

        /// <summary>
        /// The first block of text to be printed on the transport contract.
        /// </summary>
        FBC,

        /// <summary>
        /// Free text information on a transport document to indicate payment information by Government Bill of Lading.
        /// </summary>
        GBL,

        /// <summary>
        /// Note is general in nature, applies to entire transaction segment.
        /// </summary>
        GEN,

        /// <summary>
        /// Special permission for road transport of certain goods in the German dangerous goods regulation for road transport.
        /// </summary>
        GS7,

        /// <summary>
        /// [4078] Instructions on how specified goods, packages or containers should be handled.
        /// </summary>
        HAN,

        /// <summary>
        /// Information pertaining to a hazard.
        /// </summary>
        HAZ,

        /// <summary>
        /// [4070] Any remark given for the information of the consignee (CIM 21).
        /// </summary>
        ICN,

        /// <summary>
        /// Instructions regarding the cargo insurance.
        /// </summary>
        IIN,

        /// <summary>
        /// Instructions as to which freight and charges components have to be mailed to whom.
        /// </summary>
        IMI,

        /// <summary>
        /// Free text describing goods on a commercial invoice line.
        /// </summary>
        IND,

        /// <summary>
        /// Specific note contains insurance information.
        /// </summary>
        INS,

        /// <summary>
        /// Note contains invoice instructions.
        /// </summary>
        INV,

        /// <summary>
        /// [4090] Date entered by railway stations when required, e.g.specified trains, additional sheets for freight calculations, special measures, etc. (CIM 8).
        /// </summary>
        IRP,

        /// <summary>
        /// Information concerning the pre-carriage to the port of discharge if by other means than a vessel.
        /// </summary>
        ITR,

        /// <summary>
        /// Instructions regarding the testing that is required to be carried out on the items in the transaction.
        /// </summary>
        ITS,

        /// <summary>
        /// Note contains line item information.
        /// </summary>
        LIN,

        /// <summary>
        /// Instructions where specified packages or containers are to be loaded on a means of transport.
        /// </summary>
        LOI,

        /// <summary>
        /// Free text accounting information on an IATA Air Waybill to indicate payment information by Miscellaneous charge order.
        /// </summary>
        MCO,

        /// <summary>
        /// Additional information regarding the marks and numbers.
        /// </summary>
        MKS,

        /// <summary>
        /// Free text contains order instructions.
        /// </summary>
        ORI,

        /// <summary>
        /// General information created by the sender of general or specific value.
        /// </summary>
        OSI,

        /// <summary>
        /// Information regarding the packaging and/or marking of goods.
        /// </summary>
        PAC,

        /// <summary>
        /// The free text contains payment instructions information relevant to the message.
        /// </summary>
        PAI,

        /// <summary>
        /// Note contains payables information.
        /// </summary>
        PAY,

        /// <summary>
        /// Note contains packaging information.
        /// </summary>
        PKG,

        /// <summary>
        /// The text contains packaging terms information.
        /// </summary>
        PKT,

        /// <summary>
        /// The free text contains payment details.
        /// </summary>
        PMD,

        /// <summary>
        /// Note contains payments information.
        /// </summary>
        PMT,

        /// <summary>
        /// The text contains product information.
        /// </summary>
        PRD,

        /// <summary>
        /// Additional information regarding the price formula used for calculating the item price.
        /// </summary>
        PRF,

        /// <summary>
        /// Note contains priority information.
        /// </summary>
        PRI,

        /// <summary>
        /// Note contains purchasing information.
        /// </summary>
        PUR,

        /// <summary>
        /// Instructions regarding quarantine, i.e.the period during which an arriving vessel, including its equipment, cargo, crew or passengers, suspected to carry or carrying a contagious disease is detained in strict isolation to prevent the spread of such a disease.
        /// </summary>
        QIN,

        /// <summary>
        /// Specification of the quality/performance expectations or standards to which the items must conform.
        /// </summary>
        QQD,

        /// <summary>
        /// Note contains quotation information.
        /// </summary>
        QUT,

        /// <summary>
        /// Information concerning risks induced by the goods and/or handling instruction.
        /// </summary>
        RAH,

        /// <summary>
        /// The free text contains information for regulatory authority.
        /// </summary>
        REG,

        /// <summary>
        /// Free text information on an IATA Air Waybill to indicate consignment returned because of non delivery.
        /// </summary>
        RET,

        /// <summary>
        /// The text contains receivables information.
        /// </summary>
        REV,

        /// <summary>
        /// [3074] Names of places via which the consignor requests a consignment to be routed.
        /// </summary>
        RQR,

        /// <summary>
        /// [4120] Stipulation of the tariffs to be applied showing, where applicable, special-agreement numbers or references; indication of routes by frontier points or by frontier stations and, when necessary, by transit stations between.
        /// </summary>
        RQT,

        /// <summary>
        /// The text contains safety information.
        /// </summary>
        SAF,

        /// <summary>
        /// [4284] Instructions given and declarations made by the sender to the carrier concerning Customs, insurance, and other formalities.
        /// </summary>
        SIC,

        /// <summary>
        /// Special instructions like licence no, high value, handle with care, glass.
        /// </summary>
        SIN,

        /// <summary>
        /// Shipping line requested to be used for traffic between European continent and U.K. for Ireland.
        /// </summary>
        SLR,

        /// <summary>
        /// Statement that a special permission has been obtained for the transport (and/or routing) in general, and reference to such permission.
        /// </summary>
        SPA,

        /// <summary>
        /// Statement that a special permission has been obtained for the transport(and/or routing) of the goods specified, and reference to such permission.
        /// </summary>
        SPG,

        /// <summary>
        /// Note contains special handling information.
        /// </summary>
        SPH,

        /// <summary>
        /// Statement that a special permission has been obtained for the packaging, and reference to such permission.
        /// </summary>
        SPP,

        /// <summary>
        /// Statement that a special permission has been obtained for the use of the means transport, and reference to such permission.
        /// </summary>
        SPT,

        /// <summary>
        /// Number(s) of subsidiary risks, induced by the goods, according to the valid classification.
        /// </summary>
        SRN,

        /// <summary>
        /// Request for a special service concerning the transport of the goods.
        /// </summary>
        SSR,

        /// <summary>
        /// Remarks from or for a supplier of goods or services.
        /// </summary>
        SUR,

        /// <summary>
        /// [5430] Specification of the tariff applied.
        /// </summary>
        TCA,

        /// <summary>
        /// Additional information related to transport details.
        /// </summary>
        TDT,

        /// <summary>
        /// General information regarding the transport of the cargo.
        /// </summary>
        TRA,

        /// <summary>
        /// Stipulation of the tariffs to be applied showing, where applicable, special agreement numbers or references.
        /// </summary>
        TRR,

        /// <summary>
        /// The text contains a statement constituting a tax declaration.
        /// </summary>
        TXD,

        /// <summary>
        /// Note contains warehouse information.
        /// </summary>
        WHI,

        /// <summary>
        /// Note contains information mutually defined by trading partners.
        /// </summary>
        ZZZ
    }
    
}
